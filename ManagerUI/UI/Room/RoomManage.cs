using Newtonsoft.Json;
using SPA_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Data;
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
                cn_cmb.Items.Add(i.ID_CHINHANH);
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
        public int status;
        private void thêmPhòngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans = new PHONG();
            trans.ID_CHINHANH = (int)UserView.SelectedRows[0].Cells[1].Value;
            status = 0;
            RoomInsert_Update frm = new RoomInsert_Update();
            frm.status = 0;
            frm.trans = trans;
            frm.ShowDialog();
            GetPhongAsync(Convert.ToInt32(cn_cmb.Text));
        }
        PHONG trans;
        private void cậpNhậtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans = new PHONG();
            trans.ID_PHONG = (int)UserView.SelectedRows[0].Cells[0].Value;
            trans.ID_CHINHANH = (int)UserView.SelectedRows[0].Cells[1].Value;
            trans.LOAI = (int)UserView.SelectedRows[0].Cells[2].Value;
            trans.MOTA = UserView.SelectedRows[0].Cells[3].Value.ToString();
            status = 1;
            RoomInsert_Update frm = new RoomInsert_Update();
            frm.status = status;
            frm.trans = trans;
            frm.ShowDialog();
            GetPhongAsync(Convert.ToInt32(cn_cmb.Text));
        }

        private async Task<IList<PHONG>> GetPhongAsync(int cn)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "PHONGs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var ps = await response.Content.ReadAsAsync<IList<PHONG>>();
            IList<PHONG> results = ps
                             .Where(e => e.ID_CHINHANH == cn)
                             .ToList();
            //DataView dv = (DataView)ps;
            UserView.DataSource = results;
            UserView.Columns[1].Visible = false;
            UserView.Columns[5].Visible = false;
            UserView.Columns[4].Visible = false;
            return results;

        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserView.DataSource = null;
                UserView.Rows.Clear();
                GetPhongAsync(Convert.ToInt32(cn_cmb.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
