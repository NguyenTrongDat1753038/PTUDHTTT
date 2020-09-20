using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Java.Lang;
using System.Collections.Generic;
using Android.Content.PM;
using Android.Content;
using Android.Support.V7.View.Menu;
using SpaProject.Models;
using Java.IO;
using Android.Views;
using System.Net.Http;
using Newtonsoft.Json;
using Android.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace SpaProject
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        string UID;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            // You should be able to do it this way:
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (s, c, ch, err) => true;
            // Try this if that is being dumb
            System.Net.ServicePointManager.ServerCertificateValidationCallback += ServerCertificateValidationCallback;

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            TextView registerTrans = FindViewById<TextView>(Resource.Id.signup);
            TextView usernamelabel = FindViewById<TextView>(Resource.Id.usernameLabel);
            Button LoginBut = FindViewById<Button>(Resource.Id.loginBtn);
            EditText usernames = FindViewById<EditText>(Resource.Id.usernameTxtbox);
            EditText password = FindViewById<EditText>(Resource.Id.passwordTxtbox);

            /* FOR TEST ONLY
             
            var intent = new Intent(this, typeof(HomeActivity));
            intent.PutExtra("UserID", 0);
            StartActivity(intent);
            Finish();
            */


            
             // REAL CODE
            LoginBut.Click += (sender, e) =>
            {
                //GetRestfull();
                Task<string> id  = GetFromServerAsync("https://spaprojrenew.azurewebsites.net/api/USERs/?uname=" + usernames.Text+"&pword="+password.Text);
                string IDs = id.Result.Trim(new char[] {'[',']'});
                if (IDs != "")
                {
                    //usernamelabel.Text = IDs;
                    var intent = new Intent(this, typeof(HomeActivity));
                    intent.PutExtra("UserID", IDs);
                    StartActivity(intent);
                    Finish();
                }
                else
                {
                    Android.App.AlertDialog.Builder dialog = new Android.App.AlertDialog.Builder(this);
                    Android.App.AlertDialog alert = dialog.Create();
                    alert.SetTitle("Đăng nhập thất bại");
                    alert.SetMessage("Tên tài khoản hoặc mật khẩu không hợp lệ");
                    alert.SetButton("OK", (c, ev) =>
                    {
                        // Ok button click task  
                    });
                    alert.Show();
                }
            };
            
            // REAL CODE
            registerTrans.Click += RegisterTrans_Click;
        }


        private void RegisterTrans_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(RegisterActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }











        // ESTABLISH AND READ FROM DATABASE
        public async Task<string> GetFromServerAsync(string URL)
        {
            HttpClient client = PreparedClient();
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response = await client.GetAsync(URL).ConfigureAwait(false);
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception ex)
            {
                return "error";
            }
        }

        private HttpClient PreparedClient()
        {
            HttpClientHandler handler = new HttpClientHandler();

            //not sure about this one, but I think it should work to allow all certificates:
            handler.ServerCertificateCustomValidationCallback += (sender, cert, chaun, ssPolicyError) =>
            {
                return true;
            };


            HttpClient client = new HttpClient(handler);

            return client;
        }

        private bool ServerCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}