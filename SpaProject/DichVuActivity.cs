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
using Android.Support.V7.Widget;
using Newtonsoft.Json.Linq;
using Android.Support.V7.RecyclerView.Extensions;

namespace SpaProject
{
    [Activity(Label = "DichVu")]
    public class DichVuActivity : Activity
    {
        private ListView listitem;
        private List<string> itemslist;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            // Set our view from the "main" layout resource:
            SetContentView(Resource.Layout.Dichvu);

            // Get our RecyclerView layout:
            listitem = FindViewById<ListView>(Resource.Id.listView1);

            Task<string> id = GetFromServerAsync("https://spaprojrenew.azurewebsites.net/api/DICHVUs");


            string listDichvu = id.Result;

            var list = JsonConvert.DeserializeObject<List<Models.DichvuItem>>(listDichvu);
            //var object = JArray.Parse(listDichvu);
            itemslist = new List<string>();
            foreach (Models.DichvuItem ditems in list)
            {
                itemslist.Add(ditems.ID_DICHVU+ " - " + ditems.Ten +" - " + ditems.Gia);
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, itemslist);
            listitem.Adapter = adapter;
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