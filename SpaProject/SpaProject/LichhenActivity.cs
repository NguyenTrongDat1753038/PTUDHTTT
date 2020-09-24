using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using System.Net.Http;
using Newtonsoft.Json;
using Android.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.Support.V7.RecyclerView;
using System.IO;
using System.Net.Http.Headers;

namespace SpaProject
{
    [Activity(Label = "LichhenActivity")]
    public class LichhenActivity : Activity
    {
        string UserID;
        string IDCN;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here


            // Create your application here

            // Set our view from the "main" layout resource:
            SetContentView(Resource.Layout.Lichhen);

            // Get our RecyclerView layout:

            // PUBLIC VARIABLE:
            //List<Models.DichvuItem> lists;
            UserID = Intent.Extras.GetString("UserID");
            IDCN = Intent.Extras.GetString("ID_CHINHANH");

            TimePicker Timess = FindViewById<TimePicker>(Resource.Id.timePicker1);
            DatePicker Datess = FindViewById<DatePicker>(Resource.Id.datePicker1);
            //
            Timess.Is24HourView();
            var date = Datess.DateTime.Date;

            // GET STRING CONS:
            string conns = Resources.GetString(Resource.String.connectionStrings);
            //
            

            // BUTTON:
            //button DatLH = FindViewById<Button>(Resource.Id.DatLH);
            Button HoanTatLichHen = FindViewById<Button>(Resource.Id.hoantatbtn1);
            //

            //Tao toolbar

            var toolbarBottom = FindViewById<Android.Widget.Toolbar>(Resource.Id.toolbar1);

            toolbarBottom.InflateMenu(Resource.Menu.toolbarheader);
            toolbarBottom.Title = "THÔNG TIN LỊCH HẸN: ";
            toolbarBottom.MenuItemClick += (sender, e) => {
                //Toast.MakeText(this, "Bottom toolbar pressed: " + e.Item.TitleFormatted, ToastLength.Short).Show();
                Finish();
            };

            HoanTatLichHen.Click += (sender, e) =>
            {
                var c = new
                {
                    ID_KH = UserID,
                    ID_CHINHANH = IDCN,
                    GIOHEN = Timess.Hour + ":" + Timess.Minute,
                    NGAYHEN = Datess.DateTime
                };
                var cts = CreateHttpContent(c);
                Task<string> id = PostToServerAsync(conns + "api/LICHHENs" +
                    "/?t=123", cts);

                string RES = id.Result;
                string a;
                if (RES == "Ok")
                    a = RES;
            };







        }





        // ESTABLISH AND READ FROM DATABASE

        public static void SerializeJsonIntoStream(object value, Stream stream)
        {
            using (var sw = new StreamWriter(stream, new UTF8Encoding(false), 1024, true))
            using (var jtw = new JsonTextWriter(sw) { Formatting = Formatting.None })
            {
                var js = new JsonSerializer();
                js.Serialize(jtw, value);
                jtw.Flush();
            }
        }

        private static HttpContent CreateHttpContent(object content)
        {
            HttpContent httpContent = null;

            if (content != null)
            {
                var ms = new MemoryStream();
                SerializeJsonIntoStream(content, ms);
                ms.Seek(0, SeekOrigin.Begin);
                httpContent = new StreamContent(ms);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            return httpContent;
        }
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

        public async Task<string> PostToServerAsync(string URL, HttpContent c)
        {
            HttpClient client = PreparedClient();
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response = await client.PostAsync(URL,c).ConfigureAwait(false);
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception ex)
            {
                return "error";
            }
        }

        public async Task<string> PutFromServerAsync(string URL)
        {
            HttpClient client = PreparedClient();
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response = await client.PutAsync(URL, null).ConfigureAwait(false);
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