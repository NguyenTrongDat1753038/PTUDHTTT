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

namespace ManagerUI.UI.Services
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            // rest of your code here...
            GetDichVuAsync();
        }

        private async Task<IList<DICHVU>> GetDichVuAsync()
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "DICHVUs" + "?manager=" + "nva123"; //manager's username
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage response = client.GetAsync(path).Result;
            var cn = await response.Content.ReadAsAsync<IList<DICHVU>>();
            DVview.DataSource = cn;
            DVview.Columns[7].Visible = false;
            DVview.Columns[8].Visible = false;
            DVview.Columns[9].Visible = false;
            DVview.Columns[10].Visible = false;
            return cn;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DVview = new System.Windows.Forms.DataGridView();
            this.hopeRoundButtonDV = new ReaLTaiizor.Controls.HopeRoundButton();
            this.contextMenuDV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmDịchVụMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.DVview)).BeginInit();
            this.contextMenuDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // DVview
            // 
            this.DVview.AllowUserToOrderColumns = true;
            this.DVview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVview.Location = new System.Drawing.Point(12, 111);
            this.DVview.Name = "DVview";
            this.DVview.ReadOnly = true;
            this.DVview.RowHeadersVisible = false;
            this.DVview.RowHeadersWidth = 51;
            this.DVview.RowTemplate.Height = 24;
            this.DVview.Size = new System.Drawing.Size(1552, 494);
            this.DVview.TabIndex = 0;
            this.DVview.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DVview_CellMouseDown);
            this.DVview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DVview_MouseClick);
            // 
            // hopeRoundButtonDV
            // 
            this.hopeRoundButtonDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeRoundButtonDV.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.hopeRoundButtonDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeRoundButtonDV.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeRoundButtonDV.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeRoundButtonDV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeRoundButtonDV.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeRoundButtonDV.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeRoundButtonDV.Location = new System.Drawing.Point(719, 65);
            this.hopeRoundButtonDV.Name = "hopeRoundButtonDV";
            this.hopeRoundButtonDV.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRoundButtonDV.Size = new System.Drawing.Size(164, 40);
            this.hopeRoundButtonDV.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeRoundButtonDV.TabIndex = 1;
            this.hopeRoundButtonDV.Text = "Load dịch vụ";
            this.hopeRoundButtonDV.TextColor = System.Drawing.Color.White;
            this.hopeRoundButtonDV.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeRoundButtonDV.Click += new System.EventHandler(this.hopeRoundButtonDV_Click);
            // 
            // contextMenuDV
            // 
            this.contextMenuDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contextMenuDV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuDV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmDịchVụMớiToolStripMenuItem,
            this.cậpNhậtDịchVụToolStripMenuItem,
            this.xóaDịchVụToolStripMenuItem});
            this.contextMenuDV.Name = "contextMenuDV";
            this.contextMenuDV.Size = new System.Drawing.Size(197, 76);
            this.contextMenuDV.Text = "Dịch vụ";
            // 
            // thêmDịchVụMớiToolStripMenuItem
            // 
            this.thêmDịchVụMớiToolStripMenuItem.Name = "thêmDịchVụMớiToolStripMenuItem";
            this.thêmDịchVụMớiToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.thêmDịchVụMớiToolStripMenuItem.Text = "Thêm dịch vụ mới";
            this.thêmDịchVụMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmDịchVụMớiToolStripMenuItem_Click);
            // 
            // cậpNhậtDịchVụToolStripMenuItem
            // 
            this.cậpNhậtDịchVụToolStripMenuItem.Name = "cậpNhậtDịchVụToolStripMenuItem";
            this.cậpNhậtDịchVụToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.cậpNhậtDịchVụToolStripMenuItem.Text = "Cập nhật dịch vụ";
            this.cậpNhậtDịchVụToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtDịchVụToolStripMenuItem_Click);
            // 
            // xóaDịchVụToolStripMenuItem
            // 
            this.xóaDịchVụToolStripMenuItem.Name = "xóaDịchVụToolStripMenuItem";
            this.xóaDịchVụToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.xóaDịchVụToolStripMenuItem.Text = "Xóa dịch vụ";
            this.xóaDịchVụToolStripMenuItem.Click += new System.EventHandler(this.xóaDịchVụToolStripMenuItem_Click);
            // 
            // hopeRoundButton1
            // 
            this.hopeRoundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeRoundButton1.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.hopeRoundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeRoundButton1.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeRoundButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeRoundButton1.Enabled = false;
            this.hopeRoundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeRoundButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeRoundButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeRoundButton1.Location = new System.Drawing.Point(690, 12);
            this.hopeRoundButton1.Name = "hopeRoundButton1";
            this.hopeRoundButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRoundButton1.Size = new System.Drawing.Size(224, 45);
            this.hopeRoundButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeRoundButton1.TabIndex = 2;
            this.hopeRoundButton1.Text = "QUẢN LÝ DỊCH VỤ";
            this.hopeRoundButton1.TextColor = System.Drawing.Color.White;
            this.hopeRoundButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // Services
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1568, 610);
            this.Controls.Add(this.hopeRoundButton1);
            this.Controls.Add(this.hopeRoundButtonDV);
            this.Controls.Add(this.DVview);
            this.Name = "Services";
            this.Text = "ServicesManage";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVview)).EndInit();
            this.contextMenuDV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        DICHVU trans;
        public int status;

        private void thêmDịchVụMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status = 0;
            ServicesInsert_Update frm = new ServicesInsert_Update();
            frm.status = 0;
            //frm.iduser = (int)UserView.SelectedRows[0].Cells[0].Value;
            frm.ShowDialog();
            GetDichVuAsync();
        }
        
        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trans = new DICHVU();
            trans.ID_DICHVU = (int)DVview.SelectedRows[0].Cells[0].Value;
            //trans.Ten = (DVview.SelectedRows[0].Cells[1].Value == null ? 0 : (int)(DVview.SelectedRows[0].Cells[1].Value));
            trans.Ten = DVview.SelectedRows[0].Cells[1].Value.ToString();
            trans.Mota = DVview.SelectedRows[0].Cells[2].Value.ToString();
            trans.Gia = (decimal?)DVview.SelectedRows[0].Cells[3].Value;
            trans.Thoigiancho = (DVview.SelectedRows[0].Cells[4].Value == null ? 15 : (int)(DVview.SelectedRows[0].Cells[4].Value));
            trans.ThoiLuong = (int?)DVview.SelectedRows[0].Cells[5].Value;
            trans.TinhTrang = (bool)DVview.SelectedRows[0].Cells[6].Value;
            ServicesInsert_Update frm = new ServicesInsert_Update();
            status = 1;
            frm.status = status;
            frm.trans = trans;
            frm.ShowDialog();
            GetDichVuAsync();
        }

        private async void DeleteDV(int id)
        {
            string basepath = ProvidingConnection.basepath;
            string path = basepath + "/api/" + "DICHVUs/" + id;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(basepath);
            HttpResponseMessage delete = await client.DeleteAsync(path);

            string result = await delete.Content.ReadAsStringAsync();
        }

        private void xóaDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá dịch vụ này không.\n Thao tác này không thể đảo ngược", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteDV((int)DVview.SelectedRows[0].Cells[0].Value);
                GetDichVuAsync();
            }
        }

        private void hopeRoundButtonDV_Click(object sender, EventArgs e)
        {
            GetDichVuAsync();
        }

        private void DVview_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Right)
            {
                contextMenuDV.Show(Cursor.Position.X, Cursor.Position.Y);
            }*/
        }

        private void DVview_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                try
                {
                    DVview.CurrentCell = DVview.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    DVview.Rows[e.RowIndex].Selected = true;
                    DVview.Focus();
                    contextMenuDV.Show(Cursor.Position.X, Cursor.Position.Y);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

