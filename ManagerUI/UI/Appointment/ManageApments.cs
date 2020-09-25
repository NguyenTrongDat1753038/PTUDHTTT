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

namespace ManagerUI.UI.Appointment
{
    public partial class ManageApments : Form
    {
        //USER trans1;
        public ManageApments()
        {
            InitializeComponent();
        }

        private void ManageApments_Load(object sender, EventArgs e)
        {
            GetLichHenAsync();
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
            LHview.DataSource = cn;
            //CTLHview.DataSource = cn1;
            LHview.Columns[8].Visible = false;
            LHview.Columns[9].Visible = false;
            LHview.Columns[10].Visible = false;
            return cn;
        }
        private void hopeRoundButton1_Click(object sender, EventArgs e)
        {
            GetLichHenAsync();
        }

        private void LHview_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                try
                {
                    LHview.CurrentCell = LHview.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    LHview.Rows[e.RowIndex].Selected = true;
                    LHview.Focus();
                    contextMenuLH.Show(Cursor.Position.X, Cursor.Position.Y);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //CHITIET_LICHHEN trans1;
        LICHHEN trans;
        public int status;

        private void thêmLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = 0;
            ApmentsInsert_Update frm = new ApmentsInsert_Update();
            frm.status = 0;
            frm.ShowDialog();
            if (frm.insert_stat == 0)
                DeleteLH(frm.insert_id);
            GetLichHenAsync();
        }

        private void cậpNhậtLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans = new LICHHEN();
            trans.ID_LH = Convert.ToInt32(LHview.SelectedRows[0].Cells[0].Value);
            //trans.Ten = (DVview.SelectedRows[0].Cells[1].Value == null ? 0 : (int)(DVview.SelectedRows[0].Cells[1].Value));
            trans.ID_KH = Convert.ToInt32(LHview.SelectedRows[0].Cells[1].Value);
            trans.ID_CHINHANH = Convert.ToInt32(LHview.SelectedRows[0].Cells[2].Value);
            trans.GIOHEN = (LHview.SelectedRows[0].Cells[3].Value == null) ? TimeSpan.Parse("0") : TimeSpan.Parse(LHview.SelectedRows[0].Cells[3].Value.ToString());
            trans.NGAYHEN = Convert.ToDateTime(LHview.SelectedRows[0].Cells[4].Value);
            trans.TINHTRANG = Convert.ToInt32(LHview.SelectedRows[0].Cells[5].Value);
            trans.BINHLUAN = (LHview.SelectedRows[0].Cells[6].Value == null) ? "" : LHview.SelectedRows[0].Cells[6].Value.ToString();
            trans.DANHGIA = Convert.ToInt32(LHview.SelectedRows[0].Cells[7].Value);
            
            //trans1.ID_HLV = Convert.ToInt32(CTLHview.SelectedRows)
            /*IList<USER> trans1 = new IList<USER>();
            //var trans1 = GetUserIDAsync();*/
            ApmentsInsert_Update frm = new ApmentsInsert_Update();
            //frm.trans1 = (IList<USER>)trans1;
            status = 1;
            frm.status = status;
            frm.trans = trans;
            frm.ShowDialog();
            GetLichHenAsync();
        }
        private async void DeleteLH(int id)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "LICHHENs/" + id;
            string path_ct = basepath + "/api/" + "CHITIET_LICHHEN/" + id;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage delete = await client.DeleteAsync(path);
            HttpResponseMessage deletect = await client.DeleteAsync(path_ct);
            string result = await delete.Content.ReadAsStringAsync();
            string resultct = await deletect.Content.ReadAsStringAsync();
        }

        private void xóaLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá lịch hẹn này không.\n Thao tác này không thể đảo ngược", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteLH((int)LHview.SelectedRows[0].Cells[0].Value);
                GetLichHenAsync();
            }
        }

        private void xemChiTiếtLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)LHview.SelectedRows[0].Cells[0].Value;

            try
            {
                ApmentDetails frm = new ApmentDetails();
                frm.buff = id;
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Lịch hẹn chưa có thông tin");
                return;
            }
        }
    }
}
