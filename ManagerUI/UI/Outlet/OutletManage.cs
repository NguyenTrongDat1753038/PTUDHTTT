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

namespace ManagerUI.UI.Outlet
{
    public partial class OutletManage : Form
    {
        public OutletManage()
        {
            InitializeComponent();
        }

        private void OutletManage_Load(object sender, EventArgs e)
        {
            GetChiNhanhAsync();
        }

        private async Task<IList<CHINHANH>> GetChiNhanhAsync()
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "CHINHANHs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var cn = await response.Content.ReadAsAsync<IList<CHINHANH>>();
            UserView.DataSource = cn;
            UserView.Columns[5].Visible = false;
            UserView.Columns[6].Visible = false;
            UserView.Columns[7].Visible = false;
            foreach (DataGridViewRow row in UserView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCyan;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
            return cn;
        }

        private void thêmChiNhánhMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = 0;
            OutletInsert_Update frm = new OutletInsert_Update();
            frm.status = 0;
            //frm.iduser = (int)UserView.SelectedRows[0].Cells[0].Value;
            frm.ShowDialog();
            GetChiNhanhAsync();
        }
        CHINHANH trans;
        /*private void xoáChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans = new CHINHANH();
            trans.ID_CHINHANH = (int)UserView.SelectedRows[0].Cells[0].Value;
            trans.ID_USER = (int)UserView.SelectedRows[0].Cells[1].Value;
            trans.TEN = UserView.SelectedRows[0].Cells[2].Value.ToString();
            trans.DIACHI = UserView.SelectedRows[0].Cells[3].Value.ToString();
            trans.TINHTRANG = (bool)UserView.SelectedRows[0].Cells[4].Value;
            OutletInsert_Update frm = new OutletInsert_Update();
            frm.status = 1;
            frm.trans = trans;
        }*/
        public int status;

        private void cậpNhậtChiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans = new CHINHANH();
            trans.ID_CHINHANH = (int)UserView.SelectedRows[0].Cells[0].Value;
            trans.ID_USER = (UserView.SelectedRows[0].Cells[1].Value == null ? 0 : (int)(UserView.SelectedRows[0].Cells[1].Value));
            trans.TEN = UserView.SelectedRows[0].Cells[2].Value.ToString();
            trans.DIACHI = UserView.SelectedRows[0].Cells[3].Value.ToString();
            trans.TINHTRANG = (bool)UserView.SelectedRows[0].Cells[4].Value;
            OutletInsert_Update frm = new OutletInsert_Update();
            status = 1;
            frm.status = status;
            frm.trans = trans;
            frm.ShowDialog();
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
    }
}
