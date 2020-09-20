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

namespace ManagerUI.UI.Outlet
{
    public partial class OutletInsert_Update : Form
    {
        public OutletInsert_Update()
        {
            InitializeComponent();
        }
        public int status;
        public CHINHANH trans;
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void Insert()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var gizmo = new CHINHANH();
                gizmo.ID_USER = Convert.ToInt32(user.Text);
                gizmo.TEN = name.Text;
                gizmo.DIACHI = address.Text;
                gizmo.TINHTRANG = true;
                //var temp = new TTCANHAN();
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/CHINHANHs", gizmo);
                    MessageBox.Show("Thêm chi nhánh mới thành công");
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
        private async void Update(int idcn)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var gizmo = new CHINHANH();
                gizmo.ID_CHINHANH = trans.ID_CHINHANH;
                gizmo.ID_USER = trans.ID_USER;
                gizmo.TEN = trans.TEN;
                gizmo.DIACHI = trans.DIACHI;
                gizmo.TINHTRANG = khoa_cb.Checked == true ? false : true;
                try
                {
                    HttpResponseMessage update = await client.PutAsJsonAsync("api/CHINHANHs/" + idcn, gizmo);
                    MessageBox.Show("Cập nhật chi nhánh thành công");
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            Validate();
            Update(trans.ID_CHINHANH);
        }

        private void OutletInsert_Update_Load(object sender, EventArgs e)
        {
            if (status == 0)
            {
                id.Enabled = false;
                insert_btn.Enabled = true;
                update_btn.Enabled = false;
                state.Enabled = false;
                khoa_cb.Enabled = false;
                user.ReadOnly = false;

            }
            else
            {
                id.Enabled = false;
                insert_btn.Enabled = false;
                user.ReadOnly = true;
                update_btn.Enabled = true;
                state.Enabled = true;
                id.Text = trans.ID_CHINHANH.ToString();
                user.Text = trans.ID_USER.ToString();
                user.Enabled = true;
                name.Text = trans.TEN;
                address.Text = trans.DIACHI;
                khoa_cb.Enabled = true;
                state.Text = trans.TINHTRANG == true ? "Còn hoạt động" : "Đã ngừng hoạt động";
                if (trans.TINHTRANG == true)
                    khoa_cb.Checked = false;
                else
                    khoa_cb.Checked = true;
            }
        }
    }
}
