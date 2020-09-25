using RestSharp.Extensions;
using SPA_API.Controllers;
using SPA_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerUI.UI.Appointment
{
    public partial class ApmentsInsert_Update : Form
    {
        public ApmentsInsert_Update()
        {
            InitializeComponent();
        }
        public int status; //0: them, 1: cap nhat
        public LICHHEN trans;
        public CHITIET_LICHHEN trans1;
        private int temp(string t)
        {
            if (t.Trim() == "0")
                return 0;
            else if (t.Trim() == "1")
                return 1;
            else if (t.Trim() == "2")
                return 2;
            else if (t.Trim() == "3")
                return 3;
            else
                return 4;
        }
        public int insert_stat;
        public int insert_id;
        private async void Insert()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var gizmo = new LICHHEN();
                //var gizmoct = new CHITIET_LICHHEN();
                id_lh.Text = Convert.ToString(gizmo.ID_LH); //ID auto
                gizmo.ID_KH = Convert.ToInt32(id_kh.SelectedValue);
                gizmo.ID_CHINHANH = Convert.ToInt32(id_cn.SelectedValue);
                //gizmo.GIOHEN = TimeSpan.Parse(timeapm_pick.ToString());
                //gizmo.GIOHEN = timeapm_pick.ToString();
                gizmo.NGAYHEN = Convert.ToDateTime(dateapm_pick.Value.ToShortDateString());
                //gizmo.DANHGIA = Convert.ToInt32(rating);
                //gizmo.BINHLUAN = comment.ToString();
                gizmo.TINHTRANG = temp(state_cb.Text);
                //gizmo.USER
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/LICHHENs", gizmo);
                    GetLichHenAsync();
                    ApmentInsert_Update_Details frm = new ApmentInsert_Update_Details();
                    insert_id = Convert.ToInt32(updatelh.Rows[updatelh.Rows.Count - 1].Cells[0].Value);
                    frm.id = insert_id;
                    frm.ShowDialog();
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm lịch hẹn này không?", "Warning", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        insert_stat = 0;
                    }
                    else {
                        insert_stat = 1;
                        MessageBox.Show("Thêm lịch hẹn mới thành công");
                    }
                    
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show(e.Message);
                }
                this.Close();
            }
        }
        private async void Update(int idcn)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ProvidingConnection.basepath);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var gizmo = new LICHHEN();
                gizmo.ID_LH = Convert.ToInt32(id_lh.Text);  //load(status 1): set id_lh text to trans.id_lh(from datagrid selected)
                
                
                
                gizmo.ID_KH = Convert.ToInt32(id_kh.SelectedValue);
                gizmo.ID_CHINHANH = Convert.ToInt32(id_cn.SelectedValue);
                //gizmo.GIOHEN = TimeSpan.Parse(timeapm_pick.ToString());
                //gizmo.GIOHEN = timeapm_pick.ToString();
                gizmo.NGAYHEN = Convert.ToDateTime(dateapm_pick.Value.ToShortDateString());
                if (rating.Text != "")
                {
                    gizmo.DANHGIA = Convert.ToInt32(rating.Text);
                }
                gizmo.BINHLUAN = comment.Text.ToString();
                gizmo.TINHTRANG = temp(state_cb.Text);
                try
                {
                    HttpResponseMessage update = await client.PutAsJsonAsync("api/LICHHENs/" + idcn, gizmo); //put so not create new but replace existing id_lh
                    MessageBox.Show("Cập nhật lịch hẹn thành công");
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }

        }
        private async Task<IList<LICHHEN>> GetLichHenAsync()
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "LICHHENs";
            //string path_ct = basepath + "/api/" + "CHITIET_LICHHEN";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            //HttpResponseMessage response_ct = client.GetAsync(path_ct).Result;
            var cn = await response.Content.ReadAsAsync<IList<LICHHEN>>();
            //var cn1 = await response_ct.Content.ReadAsAsync<IList<CHITIET_LICHHEN>>();
            updatelh.DataSource = cn;
            //CTLHview.DataSource = cn1;
            //LHview.Columns[8].Visible = false;
            //LHview.Columns[9].Visible = false;
            //LHview.Columns[10].Visible = false;*/
            return cn;
        }
        private void create_btn_Click(object sender, EventArgs e)
        {
            Insert();
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            Validate();
            int n;
            if (rating.Text == "" || (int.TryParse(Convert.ToString(rating.Text), out n) && Convert.ToInt32(rating.Text) >= 0 && Convert.ToInt32(rating.Text) <= 5))
            {
                Update(Convert.ToInt32(id_lh.Text));
            }
            else if (int.TryParse(Convert.ToString(rating.Text), out n) == false || Convert.ToInt32(rating.Text) < 0 || Convert.ToInt32(rating.Text) > 5)
            {
                MessageBox.Show("Đánh giá phải là SỐ từ 0-5");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async Task<IList<USER>> GetUserIDAsync()    //get ID customer list for combobox
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "USERs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var cn = await response.Content.ReadAsAsync<IList<USER>>();
            id_kh.DataSource = cn;
            id_kh.DisplayMember = "ID";
            id_kh.ValueMember = "ID";
            return cn;
        }
        
        private async Task<IList<CHINHANH>> GetOutletIDAsync()    //get ID outlet list for combobox
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "CHINHANHs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var cn = await response.Content.ReadAsAsync<IList<CHINHANH>>();
            id_cn.DataSource = cn;
            id_cn.DisplayMember = "TEN";
            id_cn.ValueMember = "ID_CHINHANH";
            return cn;
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
                        ten_kh.Text = (tt != null)? tt.HOTEN : "";
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
        }

        /*private void setVaiTro(int id)
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
        }*/
        private void ApmentsInsert_Update_Load(object sender, EventArgs e)
        {
            GetUserIDAsync();
            //id_kh.DisplayMember = "ID";
            //id_kh.ValueMember = "ID";
            GetOutletIDAsync();
            //id_cn.DisplayMember = "TEN";
            //id_cn.ValueMember = "ID_CHINHANH";
            timeapm_pick.Format = DateTimePickerFormat.Time;
            timeapm_pick.ShowUpDown = true;
            /*dateapm_pick.Format = DateTimePickerFormat.Time;
            dateapm_pick.ShowUpDown = true;*/
            if (status == 0)    //them
            {
                id_lh.Enabled = false;
                create_btn.Enabled = true;
                update_btn.Enabled = false;
                rating.Enabled = false;
                comment.Enabled = false;
                add_sv_hlv.Enabled = false;
                //setVaiTro((int)trans.TinhTrang);

            }
            else    //cap nhat
            {
                id_lh.Enabled = false;
                create_btn.Enabled = false;
                rating.Enabled = true;
                comment.Enabled = true;
                add_sv_hlv.Enabled = true;
                //setVaiTro((int)trans.TinhTrang);
                update_btn.Enabled = true;
                state.Enabled = true;
                id_lh.Text = trans.ID_LH.ToString();   //id lh
                rating.Text = trans.DANHGIA.ToString();
                comment.Text = trans.BINHLUAN.ToString();   //binh luan

                id_kh.SelectedValue = trans.ID_KH;  //id kh
                id_cn.SelectedValue = trans.ID_CHINHANH;  //id cn
                ghichu.Text = trans.GIOHEN.ToString();   //gio hen dv
                dateapm_pick.Value = Convert.ToDateTime(trans.NGAYHEN.Value.ToShortDateString());   //ngay hen dv
                /*xoa_dv.Enabled = true;  //xoa dv
                state.Text = trans.TinhTrang == true ? "Còn cung cấp" : "Hết cung cấp";
                if (trans.TinhTrang == true)
                    xoa_dv.Checked = false;
                else
                    xoa_dv.Checked = true;*/
            }
        }

        private void id_kh_SelectedValueChanged(object sender, EventArgs e)
        {
            int n;
            int id;
            if (int.TryParse(Convert.ToString(id_kh.SelectedValue), out n))
            {
                id = Convert.ToInt32(id_kh.SelectedValue);
                GetUserAsync(id);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApmentInsert_Update_Details frm = new ApmentInsert_Update_Details();
            frm.id = Convert.ToInt32(id_lh.Text);
            frm.ShowDialog();
        }
    }
}
