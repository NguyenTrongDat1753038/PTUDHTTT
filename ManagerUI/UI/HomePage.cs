using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerUI.UI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void User_btn_Click(object sender, EventArgs e)
        {
            panel_scr.Controls.Clear();
            panel_scr.Visible = true;
            Users.UserManage myForm = new Users.UserManage();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel_scr.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        
        }

        private void Room_btn_Click(object sender, EventArgs e)
        {

        }

        private void Bed_btn_Click(object sender, EventArgs e)
        {

        }

        private void Outlet_btn_Click(object sender, EventArgs e)
        {
            panel_scr.Controls.Clear();
            panel_scr.Visible = true;
            Outlet.OutletManage myForm = new Outlet.OutletManage();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel_scr.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        private void Service_btn_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
