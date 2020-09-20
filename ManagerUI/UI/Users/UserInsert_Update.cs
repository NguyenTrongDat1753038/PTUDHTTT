using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPA_API.Models;

namespace ManagerUI.UI.Users
{
    public partial class UserInsert_Update : Form
    {
        public UserInsert_Update()
        {
            InitializeComponent();
        }
        public int status;
        public USER trans;
        private void update_btn_Click(object sender, EventArgs e)
        {
            Validate();
            Update(Convert.ToInt32(id.Text));
        }
        private int temp(string t)
        {
            if (t.Trim() == "Người dùng")
                return 1;
            else if (t.Trim() == "Nhân viên")
                return 2;
            else if (t.Trim() == "Bác sĩ")
                return 3;
            else
                return 4;
        }
        private async void Update(int iduser)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var gizmo = new USER();
                gizmo.ID = Convert.ToInt32(id.Text);
                gizmo.USERNAME = username.Text;
                gizmo.PASSWORDS = password.Text;
                gizmo.TinhTrang = khoa_cb.Checked == true ? false : true;
                gizmo.VaiTro = temp(vaitro_cmb.Text);
                try
                {
                    HttpResponseMessage update = await client.PutAsJsonAsync("api/USERs/"+iduser, gizmo);
                    MessageBox.Show("Cập nhật tài khoản thành công");
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
        }
        private void insert_btn_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void Insert()
        {
            /*using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var gizmo = new USER();
                gizmo.USERNAME = username.Text;
                gizmo.PASSWORDS = password.Text;
                gizmo.TinhTrang = true;
                gizmo.VaiTro = 1;
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/USERs", gizmo);
                    MessageBox.Show("Thêm tài khoản mới thành công");

                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(e.Message);
                }
            }*/
            if (password.Text == retype.Text)
            {
                Task<string> id = GetFromServerAsync("https://spaprojrenew.azurewebsites.net/api/USERs/?uname=" + username.Text + "&pword=" + password.Text);
                string re = id.Result;
                if (re == "OK")
                {
                    MessageBox.Show("Đăng ký tài khoản mới thành công");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại");
                }
            }
            else
            {
                MessageBox.Show("Password không khớp. Xin mời nhập lại");
            }
        }
        private void setVaiTro(int id)
        {
            if (id == 0)
                vaitro_cmb.Text = "Chưa hoạt động";
            else if (id == 1)
                vaitro_cmb.Text = "Người dùng";
            else if (id == 2)
                vaitro_cmb.Text = "Nhân viên";
            else if (id == 3)
                vaitro_cmb.Text = "Bác sĩ";
            else
                vaitro_cmb.Text = "Quản lí";
        }
        private void UserInsert_Update_Load(object sender, EventArgs e)
        {
            if (status == 0)
            {
                id.Enabled = false;
                insert_btn.Enabled = true;
                update_btn.Enabled = false;
                TinhTrang_cmb.Enabled = false;
                vaitro_cmb.Enabled = false;
                khoa_cb.Enabled = false;
                retype.Enabled = true;
            }
            else
            {
                id.Enabled = false;
                insert_btn.Enabled = false;
                update_btn.Enabled = true;
                TinhTrang_cmb.Enabled = true;
                vaitro_cmb.Enabled = true;
                setVaiTro((int)trans.VaiTro);
                id.Text = trans.ID.ToString();
                username.Text = trans.USERNAME;
                username.Enabled = false;
                password.Text = trans.PASSWORDS;
                password.Enabled = false;
                khoa_cb.Enabled = true;
                retype.Enabled = false;
                TinhTrang_cmb.Text = trans.TinhTrang == true ? "Chưa khoá" : "Đã khoá";
                if (trans.TinhTrang == true)
                    khoa_cb.Checked = false;
                else 
                    khoa_cb.Checked = true;
                vaitro_cmb.Text = trans.VaiTro.ToString();
            }
        }
        public async Task<string> GetFromServerAsync(string URL)
        {
           
            HttpClient client = PreparedClient();
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response = await client.PostAsync(URL, null).ConfigureAwait(false);
                string result = response.StatusCode.ToString();
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
