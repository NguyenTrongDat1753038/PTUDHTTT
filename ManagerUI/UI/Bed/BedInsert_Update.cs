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
    public partial class BedInsert_Update : Form
    {
        public BedInsert_Update()
        {
            InitializeComponent();
        }
        public int status;
        public GIUONG trans;
        private async void Insert()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var gizmo = new GIUONG();
                gizmo.ID_PHONG = trans.ID_PHONG;
                gizmo.MOTA = mota.Text;
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/GIUONGs", gizmo);
                    MessageBox.Show("Thêm giường thành công");
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
        private async void Update(int id_giuong)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var gizmo = new GIUONG();
                gizmo.ID_PHONG = trans.ID_PHONG;
                gizmo.ID_GIUONG = trans.ID_GIUONG;
                gizmo.MOTA = mota.Text;
                try
                {
                    HttpResponseMessage update = await client.PutAsJsonAsync("api/GIUONGs/" + id_giuong, gizmo);
                    MessageBox.Show("Cập nhật thông tin giường thành công");
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            Update(Convert.ToInt32(idg.Text));
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BedInsert_Update_Load(object sender, EventArgs e)
        {
            idp.ReadOnly = true;
            idp.Text = trans.ID_PHONG.ToString();
            idg.ReadOnly = true;
            idg.Text = trans.ID_GIUONG == null ? "" : trans.ID_GIUONG.ToString();
            if (status == 0)
            {
                insert_btn.Enabled = true;
                update_btn.Enabled = false;
            }
            else
            {

                insert_btn.Enabled = false;
                update_btn.Enabled = true;              
                idp.Text = trans.ID_PHONG.ToString();
                mota.Text = trans.MOTA;
            }
        }
    }
}
