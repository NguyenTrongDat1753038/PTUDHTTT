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

namespace ManagerUI.UI.Room
{
    public partial class RoomInsert_Update : Form
    {
        public RoomInsert_Update()
        {
            InitializeComponent();
        }

        private void foreverComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loai.Text == "1")
                chuthich.Text = "Phòng thường";
            else if (loai.Text == "2")
                chuthich.Text = "Phòng trung - cao cấp";
            else if (loai.Text == "3")
                chuthich.Text = "Phòng đặc biệt";
        }
        public int status;
        public PHONG trans;
        private void chuthich_TextChanged(object sender, EventArgs e)
        {
            
        }
        private async void GetChiNhanhAsync()
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/CHINHANHs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;

            var data = await response.Content.ReadAsAsync<IList<CHINHANH>>();
            /*idcn.Items.Clear();
            foreach (var i in data)
            {
                idcn.Items.Add(i.ID_CHINHANH);
            }*/
        }
        private void RoomInsert_Update_Load(object sender, EventArgs e)
        {
            if (status == 0)
            {
                //idcn.Items.Clear();
                //GetChiNhanhAsync();
                idcn.Text = trans.ID_CHINHANH.ToString();
                idcn.ReadOnly = true;
                insert_btn.Enabled = true;
                update_btn.Enabled = false;
                idp.ReadOnly = true;
               
            }
            else
            {
                idcn.Text = trans.ID_CHINHANH.ToString();
                idcn.ReadOnly = true;
                insert_btn.Enabled = false;
                idp.ReadOnly = true;
                update_btn.Enabled = true;
                idcn.Text = trans.ID_CHINHANH.ToString();
                idp.Text = trans.ID_PHONG.ToString();
                loai.Text = trans.LOAI.ToString();
                mota.Text = trans.MOTA;
            }
        }
        private async void Insert()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var gizmo = new PHONG();
                //gizmo.ID_PHONG = Convert.ToInt32(idp.Text);
                gizmo.ID_CHINHANH = Convert.ToInt32(idcn.Text);
                gizmo.LOAI = Convert.ToInt32(loai.Text);
                gizmo.MOTA = mota.Text;
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/PHONGs", gizmo);
                    MessageBox.Show("Thêm phòng thành công");
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
        private async void Update(int id_phong)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var gizmo = new PHONG();
                gizmo.ID_CHINHANH = trans.ID_CHINHANH;
                gizmo.ID_PHONG = trans.ID_PHONG;
                gizmo.LOAI = Convert.ToInt32(loai.Text);
                gizmo.MOTA = mota.Text;
                try
                {
                    HttpResponseMessage update = await client.PutAsJsonAsync("api/PHONGs/" + id_phong, gizmo);
                    MessageBox.Show("Cập nhật thông tin phòng thành công");
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            Update(trans.ID_PHONG);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
