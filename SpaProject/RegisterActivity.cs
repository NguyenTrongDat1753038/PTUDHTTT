using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

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
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);

            Button RegisterBtn = FindViewById<Button>(Resource.Id.registerBtn);
            EditText usernames = FindViewById<EditText>(Resource.Id.usernameTxtbox);
            EditText password = FindViewById<EditText>(Resource.Id.passwordTxtbox);
            EditText cpassword = FindViewById<EditText>(Resource.Id.passwordConfirmTxtbox);


            //TextView LoginTrans = FindViewById<TextView>(Resource.Id.registerBtn);


            RegisterBtn.Click += async (sender, e) =>
            {
                if(password.Text == cpassword.Text)
                {
                    Task<string> id = GetFromServerAsync("https://spaprojrenew.azurewebsites.net/api/USERs/?uname=" + usernames.Text+"&pword="+password.Text);
                    Android.App.AlertDialog.Builder dialog = new Android.App.AlertDialog.Builder(this);
                    Android.App.AlertDialog alert = dialog.Create();
                    alert.SetTitle("Đăng ký thành công");
                    alert.SetButton("OK", (c, ev) =>
                    {
                        this.Finish(); 
                    });
                    string re = id.Result;
                    if (re == "OK")
                    {
                        alert.Show();
                    }
                    else
                    {
                        alert.SetTitle("Đăng ký thất bại");
                        alert.SetMessage("Loi trong viec tao tai khoan");
                        alert.SetButton("OK", (c, ev) =>
                        {
                            // Ok button click task  
                        });
                        alert.Show();
                    }
                }
                else
                {
                    Android.App.AlertDialog.Builder dialog = new Android.App.AlertDialog.Builder(this);
                    Android.App.AlertDialog alert = dialog.Create();
                    alert.SetTitle("Đăng ký thất bại");
                    alert.SetMessage("mật khẩu không trùng khớp");
                    alert.SetButton("OK", (c, ev) =>
                    {
                        // Ok button click task  
                    });
                    alert.Show();
                }    
            };
            //LoginTrans.Click += LoginTrans_Click;
        }

        private void LoginTrans_Click(object sender, EventArgs e)
        {
            this.Finish();
        }



        // ESTABLISH AND READ FROM DATABASE
        public async Task<string> GetFromServerAsync(string URL)
        {
            /*
            Models.RegisterU obj = new Models.RegisterU();
            obj.uname = uname;
            obj.pword = pword;*/
            HttpClient client = PreparedClient();
            HttpResponseMessage response = new HttpResponseMessage();
            //var stringContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            
            try
            {
                response = await client.PostAsync(URL, null).ConfigureAwait(false);
                string result = response.StatusCode.ToString();
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