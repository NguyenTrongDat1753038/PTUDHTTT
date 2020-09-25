using RestSharp.Extensions;
using SPA_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManagerUI.UI.Appointment
{
    public partial class Apment_AddSV_HLV : Form
    {
        public int id;
        //public int status;
        public Apment_AddSV_HLV()
        {
            InitializeComponent();
        }
        //CHITIET_LICHHEN trans;
        private void add_services_btn_Click(object sender, EventArgs e)
        {
            Insert(id);
        }
        private async void Insert(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var gizmo = new CHITIET_LICHHEN();
                //sv_cb.Text = Convert.ToString(gizmo.ID_LH); //ID auto
                gizmo.ID_LH = id;
                gizmo.ID_DICHVU = Convert.ToInt32(sv_cb.SelectedValue);
                gizmo.ID_HLV = Convert.ToInt32(hlv_cb.SelectedValue);
                gizmo.ID_GIUONG = Convert.ToInt32(bed_cb.SelectedValue);
                gizmo.TRANGTHAI = trangthai_cb.SelectedIndex;
                gizmo.GHICHU = ghichu.Text;
                //gizmo.GIUONG.CHITIET_GIUONG =
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/CHITIET_LICHHEN", gizmo);
                    MessageBox.Show("Thêm dịch vụ thành công");
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(e.Message);
                }
                this.Close();
            }
        }
        

        private void cancel_dv_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apment_AddSV_HLV_Load(object sender, EventArgs e)
        {
            GetHLVAsync();
            GetSVAsync();
            GetBedAsync();
        }
        private async Task<IList<GIUONG>> GetBedAsync()    //get ID customer list for combobox
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "GIUONGs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var cn = await response.Content.ReadAsAsync<IList<GIUONG>>();
            bed_cb.DataSource = cn;
            bed_cb.DisplayMember = "Ten";
            bed_cb.ValueMember = "ID_GIUONG";
            return cn;
        }
        private async Task<IList<DICHVU>> GetSVAsync()    //get ID customer list for combobox
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "DICHVUs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var cn = await response.Content.ReadAsAsync<IList<DICHVU>>();
            sv_cb.DataSource = cn;
            sv_cb.DisplayMember = "Ten";
            sv_cb.ValueMember = "ID_DICHVU";
            return cn;
        }
        private async Task<IList<TTCANHAN>> GetHLVAsync()    //get ID customer list for combobox
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "USERs/HLV";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var cn = await response.Content.ReadAsAsync<IList<TTCANHAN>>();
            hlv_cb.DataSource = cn;
            hlv_cb.DisplayMember = "HOTEN";
            hlv_cb.ValueMember = "ID_USER";
            return cn;
        }
        /*private async void GetUserAsync(int id) 
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ProvidingConnection.basepath);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    string path = "/api/TTCANHANs/" + id.ToString();
                    HttpResponseMessage response = await client.GetAsync(path);
                    try
                    {
                        TTCANHAN tt = await response.Content.ReadAsAsync<TTCANHAN>();
                        ten_hlv.Text = (tt != null) ? tt.HOTEN : "";
                    }
                    catch (HttpRequestException e)
                    {
                        //MessageBox.Show(e.Message);
                        //MessageBox.Show("Người dùng chưa có thông tin");
                    }
                }

            }
            catch (Exception)
            {
                //MessageBox.Show("Hiện tại người dùng chưa có thông tin");
            }
        }*/

        /*private void hlv_cb_SelectedValueChanged(object sender, EventArgs e)
        {
           int n;
            int id;
            if (int.TryParse(Convert.ToString(hlv_cb.SelectedValue), out n))
            {
                id = Convert.ToInt32(hlv_cb.SelectedValue);
                GetUserAsync(id);
            }
        }*/
    }
}
