using Microsoft.VisualBasic.FileIO;
using SPA_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerUI.UI.Bed
{
    public partial class BedManage : Form
    {
        public BedManage()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (phong_cmb.Text == "")
            {
                MessageBox.Show("Mời chọn phòng");
            }
            else
            {
                GetGiuongAsync(Convert.ToInt32(phong_cmb.Text));
            }
        }
        private async void GetChiNhanhAsync()
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/CHINHANHs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;

            var data = await response.Content.ReadAsAsync<IList<CHINHANH>>();
            cn_cmb.Items.Clear();
            foreach (var i in data)
            {
                cn_cmb.Items.Add(i.ID_CHINHANH);
            }
        }
        private async void GetPhongAsync(int cn)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "PHONGs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var ps = await response.Content.ReadAsAsync<IList<PHONG>>();
            IList<PHONG> results = ps.Where(e => e.ID_CHINHANH == cn).ToList();
            foreach (var i in results)
            {
                phong_cmb.Items.Add(i.ID_PHONG);
            }
        }
        private void cn_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            phong_cmb.Items.Clear();
            GetPhongAsync(Convert.ToInt32(cn_cmb.Text));
        }
        private async void GetGiuongAsync(int idphong)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "GIUONGs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var ps = await response.Content.ReadAsAsync<IList<GIUONG>>();
            IList<GIUONG> results = ps.Where(e => e.ID_PHONG == idphong).ToList();
            UserView.DataSource = null;
            UserView.Columns.Clear();
            UserView.DataSource = results;
            //UserView.Columns[1].Visible = false;
            UserView.Columns[3].Visible = false;
            UserView.Columns[4].Visible = false;
            UserView.Columns[5].Visible = false;
        }
        private void UserView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    UserView.CurrentCell = UserView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    UserView.Rows[e.RowIndex].Selected = true;
                    UserView.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menu.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void BedManage_Load(object sender, EventArgs e)
        {
            GetChiNhanhAsync();
        }

        private void chiTiếtGiườngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public int status;
        public GIUONG trans;
        private void thêmPhòngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans = new GIUONG();
            status = 0;
            trans.ID_PHONG = (int)UserView.SelectedRows[0].Cells[1].Value;
            BedInsert_Update frm = new BedInsert_Update();
            frm.trans = trans;
            frm.status = status;
            frm.ShowDialog();
            GetGiuongAsync(Convert.ToInt32(phong_cmb.Text));
        }

        private void cậpNhậtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans = new GIUONG();
            trans.ID_PHONG = (int)UserView.SelectedRows[0].Cells[1].Value;
            trans.ID_GIUONG = (int)UserView.SelectedRows[0].Cells[0].Value;
            trans.MOTA = UserView.SelectedRows[0].Cells[2].Value.ToString();
            status = 1;
            BedInsert_Update frm = new BedInsert_Update();
            frm.status = status;
            frm.trans = trans;
            frm.ShowDialog();
            GetGiuongAsync(Convert.ToInt32(phong_cmb.Text));
        }
        private async void DeleteServiceAsync(int idgiuong)
        {
            string basepath = ProvidingConnection.basepath;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            string path = basepath + "/api/" + "CHITIET_GIUONGs";
            HttpResponseMessage response = client.GetAsync(path).Result;
            var ps = await response.Content.ReadAsAsync<IList<CHITIET_GIUONG>>();
            IList<CHITIET_GIUONG> results = ps
                             .Where(e => e.ID_GIUONG == idgiuong)
                             .ToList();
            List<int> list = new List<int>();
            foreach (var i in results)
            {
                list.Add(i.ID_DICHVU);
            }
            foreach (int i in list)
            {
                string path2 = path+"?ID_GIUONG="+idgiuong.ToString()+"&ID_DICHVU="+list[i].ToString();
                HttpResponseMessage delete = await client.DeleteAsync(path);
                string result = await delete.Content.ReadAsStringAsync();
                path2 = path;
            }        
        }

        private async void DeleteChiTietGiuong(int idgiuong)
        {
            DeleteServiceAsync(idgiuong);
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "GIUONGs/"+idgiuong.ToString();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage delete = await client.DeleteAsync(path);

            string result = await delete.Content.ReadAsStringAsync();
        }
        private void xoáGiườngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
