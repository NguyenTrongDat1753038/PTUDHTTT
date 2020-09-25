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
            panel_scr.Controls.Clear();
            panel_scr.Visible = true;
            Room.RoomManage myForm = new Room.RoomManage();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel_scr.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        private void Bed_btn_Click(object sender, EventArgs e)
        {
            panel_scr.Controls.Clear();
            panel_scr.Visible = true;
            Bed.BedManage myForm = new Bed.BedManage();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel_scr.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
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
            panel_scr.Controls.Clear();
            panel_scr.Visible = true;
            Services.Services myForm = new Services.Services();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel_scr.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Appoint_btn_Click(object sender, EventArgs e)
        {
            panel_scr.Controls.Clear();
            panel_scr.Visible = true;
            Appointment.ManageApments myForm = new Appointment.ManageApments();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panel_scr.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }
    }
}
