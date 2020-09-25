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

namespace ManagerUI.UI.Bed
{
    public partial class BedService : Form
    {
        public BedService()
        {
            InitializeComponent();
        }
        public int id_phong;

        private async void GetData(int id)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/CHITIET_GIUONG";
            HttpClient client1 = new HttpClient();
            client1.BaseAddress = new Uri(basepath);
            HttpResponseMessage response1 = client1.GetAsync(path).Result;
            var ps1 = await response1.Content.ReadAsAsync<IList<CHITIET_GIUONG>>();
            IList<CHITIET_GIUONG> results1 = ps1.Where(e => e.ID_GIUONG == id).ToList();
            path = basepath + "/api/DICHVUs";
            HttpClient client2 = new HttpClient();
            client2.BaseAddress = new Uri(basepath);
            HttpResponseMessage response2 = client2.GetAsync(path).Result;
            var ps2 = await response2.Content.ReadAsAsync<IList<DICHVU>>();
            IList<DICHVU> results2 = ps2.ToList();
            var ServiceInfo = (from d in results1 join dc in results2 on  d.ID_DICHVU equals dc.ID_DICHVU select new  { d.ID_GIUONG, dc.ID_DICHVU, dc.Ten,dc.Gia }).ToList(); ;
            UserView.DataSource = null;
            UserView.Columns.Clear();
            UserView.DataSource = ServiceInfo;
        }
        private void BedService_Load(object sender, EventArgs e)
        {
            GetData(id_phong);
        }
        private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BedServiceInsert_Delete frm = new BedServiceInsert_Delete();
            frm.id_giuong = id_phong;
            frm.ShowDialog();
            GetData(id_phong);
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
        private async void DeleteService(CHITIET_GIUONG tt)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "CHITIET_GIUONG";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);

            MessageBox.Show("Xoá thành công");
            //string result = await delete.Content.ReadAsStringAsync();
        }
        private void xoáDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHITIET_GIUONG tt = new CHITIET_GIUONG();
            tt.ID_DICHVU = (int)UserView.SelectedRows[0].Cells[1].Value;
            tt.ID_GIUONG = (int)UserView.SelectedRows[0].Cells[0].Value;
            try
            {
                DeleteService(tt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetData(id_phong);
        }
    }
}
