using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using SPA_API.Models;
using Newtonsoft.Json;
using System.Net;
using System.Configuration.Provider;
using System.Web.Http;
using SPA_API.Controllers;
using System.Net.Http.Headers;

namespace ManagerUI.UI.Users
{
    public partial class UserManage : Form
    {
        public Boolean NewUser = false;
        public UserManage()
        {
            InitializeComponent();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {

        }
        /*private async void GetUserAsync()
        {

            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/USERs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;

            // reading Api as String, just to show text results into a TextBox
            var result = await response.Content.ReadAsStringAsync();
            //txtGetResult.Text = result;

            IList<USER> users_ls = JsonConvert.DeserializeObject<IList<USER>>(result);

            // selecting just interest columns
            var cols = from b in users_ls
                       select new { b.ID, b.USERNAME, b.PASSWORDS, b.TinhTrang,b.VaiTro };
            UserView.DataSource = null;
            UserView.DataSource = cols.ToList();
        }*/

        private async Task<IList<USER>> GetUserAsync()
        {
            // invoking API
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "USERs";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var users = await response.Content.ReadAsAsync<IList<USER>>();
            UserView.DataSource = users;
            for (int i =5;i<=10;i++)
            {
                UserView.Columns[i].Visible = false;
            }
            return users;
        }
        public int status;
        private void thêmNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = 0;
            UserInsert_Update frm = new UserInsert_Update();
            frm.status = 0;
            //frm.iduser = (int)UserView.SelectedRows[0].Cells[0].Value;
            frm.ShowDialog();
            GetUserAsync();
        }
        private async void DeleteUser(int id)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "USERs/" + id.ToString();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage delete = await client.DeleteAsync(path);
         
            string result = await delete.Content.ReadAsStringAsync();
        }
        private void xoáNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá tài khoản này không.\n Thao tác này không thể đảo ngược", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteUser((int)UserView.SelectedRows[0].Cells[0].Value);
            }
            GetUserAsync();
        }
        USER trans = new USER();
        private void cậpNhậtNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                trans.ID = (int)UserView.SelectedRows[0].Cells[0].Value;
                trans.USERNAME = UserView.SelectedRows[0].Cells[1].Value.ToString();
                trans.PASSWORDS = UserView.SelectedRows[0].Cells[2].Value.ToString();
                trans.TinhTrang = (bool)(UserView.SelectedRows[0].Cells[3].Value) == null ? false : (bool)(UserView.SelectedRows[0].Cells[3].Value);
                trans.VaiTro = (int)UserView.SelectedRows[0].Cells[4].Value == null ? 0 : (int)UserView.SelectedRows[0].Cells[4].Value;
                status = 1;
                UserInsert_Update frm = new UserInsert_Update();
                frm.trans = trans;
                frm.status = 1;
                frm.ShowDialog();
                GetUserAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
      
        private void xemThôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)UserView.SelectedRows[0].Cells[0].Value;

            try
            {
                 UserDetail frm = new UserDetail();
                 frm.buff = id;
                 frm.ShowDialog();
            }
            catch (Exception)
            {
                 MessageBox.Show("Người dùng chưa có thông tin"); return;
            }
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
                menuUser.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            GetUserAsync();
        }
    }
}
