using RestSharp.Extensions;
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

namespace ManagerUI.UI.Appointment
{
    public partial class ApmentInsert_Update_Details : Form
    {
        public ApmentInsert_Update_Details()
        {
            InitializeComponent();
        }
        public int id;

        private async Task<IList<CHITIET_LICHHEN>> GetCTLichHenAsync()
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "CHITIET_LICHHEN";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var cn = await response.Content.ReadAsAsync<IList<CHITIET_LICHHEN>>();
            ctlh_dv.DataSource = cn;
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[ctlh_dv.DataSource];
            for (int i = 0; i < ctlh_dv.RowCount; i++) { 
                if ((int)ctlh_dv.Rows[i].Cells[0].Value != id)
                {
                    currencyManager1.SuspendBinding();
                    ctlh_dv.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
            return cn;
        }
        
        private void ApmentInsert_Update_Details_Load(object sender, EventArgs e)
        {
            GetCTLichHenAsync();
        }
        //CHITIET_LICHHEN trans;
        private void ctlh_dv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                try
                {
                    ctlh_dv.CurrentCell = ctlh_dv.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    ctlh_dv.Rows[e.RowIndex].Selected = true;
                    ctlh_dv.Focus();
                    contextMenuLH_DV.Show(Cursor.Position.X, Cursor.Position.Y);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apment_AddSV_HLV frm = new Apment_AddSV_HLV();
            frm.id = Convert.ToInt32(id);
            //frm.status = 0;
            //frm.iduser = (int)UserView.SelectedRows[0].Cells[0].Value;
            frm.ShowDialog();
            GetCTLichHenAsync();
        }

        private void xóaDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá dịch vụ này không.\n Thao tác này không thể đảo ngược", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteDV((int)ctlh_dv.SelectedRows[0].Cells[0].Value);
                GetCTLichHenAsync();
            }*/
        }
        private async void DeleteDV(int id)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "CHITIET_LICHHEN/" + id;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage delete = await client.DeleteAsync(path);
            string result = await delete.Content.ReadAsStringAsync();
        }
        private void hopeRoundButton1_Click(object sender, EventArgs e)
        {
            Apment_AddSV_HLV frm = new Apment_AddSV_HLV();
            frm.id = Convert.ToInt32(id);
            //frm.status = 0;
            //frm.iduser = (int)UserView.SelectedRows[0].Cells[0].Value;
            frm.ShowDialog();
            GetCTLichHenAsync();
        }
    }
}
