using Org.BouncyCastle.X509;
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

namespace ManagerUI.UI.Bed
{
    public partial class BedServiceInsert_Delete : Form
    {
        public BedServiceInsert_Delete()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void GetName(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ProvidingConnection.basepath);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    string path = "/api/DICHVUs/" + id.ToString();
                    HttpResponseMessage response = await client.GetAsync(path);
                    try
                    {
                        DICHVU tt = await response.Content.ReadAsAsync<DICHVU>();
                        mota.Text = tt.Ten;
                    }
                    catch (HttpRequestException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void foreverComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetName(Convert.ToInt32(iddv.Text));
        }
        public int id_giuong;
        private void BedServiceInsert_Delete_Load(object sender, EventArgs e)
        {
            idp.Text = id_giuong.ToString();
            GetDichVuAsync();
        }
        private async void GetDichVuAsync()
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "DICHVUs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var ps = await response.Content.ReadAsAsync<IList<DICHVU>>();
            foreach (var i in ps)
            {
                iddv.Items.Add(i.ID_DICHVU);
            }
        }

        private async void Insert()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var gizmo = new CHITIET_GIUONG();
                gizmo.ID_GIUONG = Convert.ToInt32(idp.Text);
                gizmo.ID_DICHVU = Convert.ToInt32(iddv.Text);
                //gizmo.TNHTRANG = 1;
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/CHITIET_GIUONG", gizmo);
                    MessageBox.Show("Thêm dịch vụ cho giường thành công");
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void insert_btn_Click(object sender, EventArgs e)
        {
            Insert();
        }
    }
}
