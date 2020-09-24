using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
using SpaProject.Models;
using SpaProject.Resources;

namespace SpaProject
{
    [Activity(Label = "GiohangActivity")]
    public class GiohangActivity : Activity
    {
        private ListView listitem;
        private List<string> itemslist;
        private Spinner spin;
        string IDCN;
        List<Models.DichvuItem> lists;
        string UserID;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            // Set our view from the "main" layout resource:
            SetContentView(Resource.Layout.Giohang);

            // Get our RecyclerView layout:

            // PUBLIC VARIABLE:
            //List<Models.DichvuItem> lists;
            var UserID = Intent.Extras.GetString("UserID");
            //


            // GET STRING CONS:
            string conns = Resources.GetString(Resource.String.connectionStrings);
            //


            // BUTTON:
            Button DatLH = FindViewById<Button>(Resource.Id.DatLH);
            //

            //Tao toolbar

            var toolbarBottom = FindViewById<Android.Widget.Toolbar>(Resource.Id.toolbar1);

            toolbarBottom.InflateMenu(Resource.Menu.toolbarheader);
            toolbarBottom.Title = "Giỏ hàng";
            toolbarBottom.MenuItemClick += (sender, e) => {
                //Toast.MakeText(this, "Bottom toolbar pressed: " + e.Item.TitleFormatted, ToastLength.Short).Show();
                Finish();
            };

            //

            // Spiner + listview 
            listitem = FindViewById<ListView>(Resource.Id.listView1);
            spin = FindViewById<Spinner>(Resource.Id.spinner1);

            //string conns = Resources.GetString(Resource.String.connectionStrings);
            Task<string> idcn = GetFromServerAsync(conns + "api/CHINHANHs/?temp=123");


            string listChinhanhs = idcn.Result;

            var listCN = JsonConvert.DeserializeObject<List<Models.CHINHANHs>>(listChinhanhs);
            //var object = JArray.Parse(listDichvu);
            itemslist = new List<string>();
            foreach (Models.CHINHANHs citems in listCN)
            {
                if (false)
                {
                    //Sửa lại database sao cho có true để test xem nếu tình trạng không active thì không hiện lên
                }
                itemslist.Add(citems.ID_CHINHANH + " - " + citems.TEN);
            }

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, itemslist);
            spin.Adapter = adapter;


            itemslist.Clear();

            //string IDCN;

            spin.ItemSelected += (object sender, AdapterView.ItemSelectedEventArgs args) =>
            {
                //Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
                string input = ((TextView)args.View).Text;
                string[] CTDichvu = input.Split('-');
                IDCN = input.Substring(0, input.IndexOf(" - "));

                // EXCUTE LOAD LISTVIEW WHEN CHOOSE DIFFEREN OUTLET:

                Task<string> id = GetFromServerAsync(conns + "api/GIOHANGs" +
                    "/?user="+UserID + "&cid=" + IDCN);


                string listDichvu = id.Result;

                var list = JsonConvert.DeserializeObject<List<Models.DichvuItem>>(listDichvu);
                lists = list;
                //var object = JArray.Parse(listDichvu);
                itemslist = new List<string>();
                foreach (Models.DichvuItem ditems in list)
                {
                    if (ditems.TinhTrang)
                    {
                        //Sửa lại database sao cho có true để test xem nếu tình trạng không active thì không hiện lên
                    }
                    itemslist.Add(ditems.ID_DICHVU + " - " + ditems.Ten + " - " + ditems.Gia + "VNĐ");
                }

                adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, itemslist);
                listitem.Adapter = adapter;


                

            };

            DatLH.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(LichhenActivity));
                intent.PutExtra("UserID", UserID);
                intent.PutExtra("ID_CHINHANH", IDCN);
                StartActivity(intent);
            };


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