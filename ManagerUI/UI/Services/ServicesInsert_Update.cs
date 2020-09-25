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

namespace ManagerUI.UI.Services
{
    public partial class ServicesInsert_Update : Form
    {
        public ServicesInsert_Update()
        {
            InitializeComponent();
        }
        public int status;
        public DICHVU trans;

        private void cancel_Btn_Click(object sender, EventArgs e)
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

                var gizmo = new DICHVU();
                id.Text = Convert.ToString(gizmo.ID_DICHVU); //ID auto
                gizmo.Ten = name.Text;
                gizmo.Mota = description.Text;
                gizmo.Gia = Convert.ToInt32(price.Text);
                if (string.IsNullOrEmpty(timewait.Text))    //default time transit to 15min
                {
                    gizmo.Thoigiancho = 15;
                }
                else
                {
                    gizmo.Thoigiancho = Convert.ToInt32(timewait.Text);
                }                    
                gizmo.ThoiLuong = Convert.ToInt32(length.Text);
                gizmo.TinhTrang = true;
                //var temp = new TTCANHAN();
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/DICHVUs", gizmo);
                    MessageBox.Show("Thêm dịch vụ mới thành công");
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(e.Message);
                }
                this.Close();
            }
        }

        private void create_Btn_Click(object sender, EventArgs e)
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
                var gizmo = new DICHVU();
                gizmo.ID_DICHVU = Convert.ToInt32(id.Text);
                gizmo.Ten = name.Text;
                gizmo.Mota = description.Text;
                gizmo.Gia = Convert.ToDecimal(price.Text);
                gizmo.Thoigiancho = Convert.ToInt32(timewait.Text);
                gizmo.ThoiLuong = Convert.ToInt32(length.Text);
                gizmo.TinhTrang = xoa_dv.Checked == true ? false : true;
                try
                {
                    HttpResponseMessage update = await client.PutAsJsonAsync("api/DICHVUs/" + idcn, gizmo);
                    MessageBox.Show("Cập nhật dịch vụ thành công");
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }

        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            Validate();
            Update(Convert.ToInt32(id.Text));
        }

        private void ServicesInsert_Update_Load(object sender, EventArgs e)
        {
            if (status == 0)
            {
                id.Enabled = false;
                create_Btn.Enabled = true;
                update_Btn.Enabled = false;
                state.Enabled = false;
                xoa_dv.Enabled = false;
                name.ReadOnly = false;
                //description.ReadOnly = false;

            }
            else
            {
                id.Enabled = false;
                create_Btn.Enabled = false;

                //name.ReadOnly = true;
                name.ReadOnly = false;

                update_Btn.Enabled = true;
                state.Enabled = true;
                id.Text = trans.ID_DICHVU.ToString();   //id dv
                description.Text = trans.Mota.ToString();   //mo ta dv
                name.Enabled = true;
                name.Text = trans.Ten;  //ten dv
                price.Text = trans.Gia.ToString();  //gia dv
                timewait.Text = trans.Thoigiancho.ToString();   //time transit dv
                length.Text = trans.ThoiLuong.ToString();   //thoi luong dv
                xoa_dv.Enabled = true;  //xoa dv
                state.Text = trans.TinhTrang == true ? "Còn cung cấp" : "Hết cung cấp";
                if (trans.TinhTrang == true)
                    xoa_dv.Checked = false;
                else
                    xoa_dv.Checked = true;
            }
        }
    }
}
