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

namespace SpaProject.Resources
{


    [Activity(Label = "Dichvu_CtActivity")]
    public class Dichvu_CtActivity : Activity
    {
        string UserID;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // GET STRING CONS:
            string conns = Resources.GetString(Resource.String.connectionStrings);
            //


            // Create your application here

            var DichvuID = Intent.Extras.GetInt("DichvuID");
            var TenDichvu = Intent.Extras.GetString("TenDichvu");
            var Mota = Intent.Extras.GetString("MotaDichvu");
            var Gia = Intent.Extras.GetString("GiaDichvu");
            var Thoigiancho = Intent.Extras.GetString("ThoigianCho");
            var ThoiLuong = Intent.Extras.GetString("ThoiLuong");
            UserID = Intent.Extras.GetString("UserID");

            SetContentView(Resource.Layout.Dichvu_CT);

            // CREATE TOOLBAR

            var toolbar1 = FindViewById<Android.Widget.Toolbar>(Resource.Id.toolbar1);

            toolbar1.InflateMenu(Resource.Menu.toolbarheader);
            toolbar1.Title = "Dịch vụ: " + TenDichvu;
            toolbar1.MenuItemClick += (sender, e) =>
            {
                //Toast.MakeText(this, "Bottom toolbar pressed: " + e.Item.TitleFormatted, ToastLength.Short).Show();
                Finish();
            };

            //

            var IDDichvu = FindViewById<TextView>(Resource.Id.DichvID);
            var TDichvu = FindViewById<TextView>(Resource.Id.DichvTen);
            var MotaDichvu = FindViewById<TextView>(Resource.Id.DichvuMota);
            var GiaDichvu = FindViewById<TextView>(Resource.Id.DichvuGia);
            var thoigiancho = FindViewById<TextView>(Resource.Id.ThoigianCho);
            var thoiluong = FindViewById<TextView>(Resource.Id.ThoiLuong);



            // GET DATA CHI TIET DICH VU

            IDDichvu.Text = "ID: " + DichvuID.ToString();
            TDichvu.Text = "Tên: " + TenDichvu;
            MotaDichvu.Text = "Mô tả: " + Mota;
            GiaDichvu.Text = "Giá: " + Gia;
            thoigiancho.Text = "Thời gian chờ: " + Thoigiancho;
            thoiluong.Text = "Thời lượng: " + ThoiLuong;


            //

            // GET ALL BUTTON:
            Button Dat = FindViewById<Button>(Resource.Id.DatDichvu);
            //

            // Chuc nang vao gio hang

            Dat.Click += (sender, e) =>
            {
                Task<string> id = PutFromServerAsync(conns + "api/GIOHANGs/?user=" + UserID + "&did=" + DichvuID.ToString());
                Android.App.AlertDialog.Builder dialog = new Android.App.AlertDialog.Builder(this);
                Android.App.AlertDialog alert = dialog.Create();
                alert.SetTitle("Thêm vào giỏ hàng thành công");
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
                    alert.SetTitle("Thêm vào giỏ hàng thất bại thất bại");
                    alert.SetMessage(re);
                    alert.SetButton("OK", (c, ev) =>
                    {
                        // Ok button click task  
                    });
                    alert.Show();
                }
            };


            //







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
                response = await client.PutAsync(URL,null).ConfigureAwait(false);
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