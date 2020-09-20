using Newtonsoft.Json;
using SPA_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace ManagerUI.UI.Room
{
    public partial class RoomManage : Form
    {
        public RoomManage()
        {
            InitializeComponent();
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
                string t = i.ToString();
                t = t.Substring(15, 8);
                cn_cmb.Items.Add(t);
            }
        }
        private void RoomManage_Load(object sender, EventArgs e)
        {
            GetChiNhanhAsync();
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

        private void thêmPhòngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void GetPhongAsync(int cn)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/PHONGs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;

            var result = await response.Content.ReadAsStringAsync();

            IList<PHONG> rm = JsonConvert.DeserializeObject<IList<PHONG>>(result);
            var cols = from d in rm select new { d.ID_PHONG, d.ID_CHINHANH,d.LOAI,d.MOTA};
            cols = cols.Where(c => c.ID_CHINHANH == cn);
            UserView.DataSource = null;
            UserView.DataSource = cols;
            UserView.Columns[1].Visible = false;
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            //GetPhongAsync(Convert.ToInt32(cn_cmb.Text));
        }
    }
}
