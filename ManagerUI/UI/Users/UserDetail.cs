using Newtonsoft.Json;
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

namespace ManagerUI.UI.Users
{
    public partial class UserDetail : Form
    {
        public UserDetail()
        {
            InitializeComponent();
        }
        public int buff;
        private void UserDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void GetUserAsync(int id)
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
                        hoten_lbl.Text = tt.HOTEN;
                        nghenghiep_lbl.Text = tt.NGHENGHIEP;
                        ngaysinh_lbl.Text = tt.NGAYSINH.ToString();
                        gioitinh_lbl.Text = tt.GIOITINH == true ? "Nam" : "Nữ";
                        thoiquen_lbl.Text = tt.THOIQUEN;
                        chieucao_lbl.Text = tt.CHIEUCAO.ToString();
                        trongluong_lbl.Text = tt.TRONGLUONG.ToString();
                        mo_lbl.Text = tt.MO.ToString();
                        mobung_lbl.Text = tt.MOBUNG.ToString();
                        bmi_lbl.Text = tt.BMI.ToString();
                    }
                    catch (HttpRequestException e)
                    {
                        MessageBox.Show(e.Message);
                        //MessageBox.Show("Người dùng chưa có thông tin");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hiện tại người dùng chưa có thông tin");
            }
        }
        private void LoadData()
        {
            GetUserAsync(buff);
        }
    }
}
