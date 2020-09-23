namespace ManagerUI.UI.Room
{
    partial class RoomManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserView = new System.Windows.Forms.DataGridView();
            this.hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            this.menu = new ReaLTaiizor.Controls.MaterialContextMenuStrip();
            this.thêmPhòngMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cn_cmb = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeRoundButton2 = new ReaLTaiizor.Controls.HopeRoundButton();
            this.LoadBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserView
            // 
            this.UserView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.UserView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.UserView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UserView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserView.Location = new System.Drawing.Point(0, 66);
            this.UserView.MultiSelect = false;
            this.UserView.Name = "UserView";
            this.UserView.ReadOnly = true;
            this.UserView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserView.RowHeadersVisible = false;
            this.UserView.RowHeadersWidth = 51;
            this.UserView.RowTemplate.Height = 24;
            this.UserView.Size = new System.Drawing.Size(1568, 544);
            this.UserView.TabIndex = 15;
            this.UserView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserView_CellMouseDown);
            this.UserView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserView_MouseClick);
            // 
            // hopeRoundButton1
            // 
            this.hopeRoundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeRoundButton1.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.hopeRoundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeRoundButton1.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeRoundButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeRoundButton1.Enabled = false;
            this.hopeRoundButton1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeRoundButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeRoundButton1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.hopeRoundButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeRoundButton1.Location = new System.Drawing.Point(67, 12);
            this.hopeRoundButton1.Name = "hopeRoundButton1";
            this.hopeRoundButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRoundButton1.Size = new System.Drawing.Size(349, 40);
            this.hopeRoundButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeRoundButton1.TabIndex = 16;
            this.hopeRoundButton1.Text = "Quản lý phòng";
            this.hopeRoundButton1.TextColor = System.Drawing.Color.White;
            this.hopeRoundButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menu.Depth = 0;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmPhòngMớiToolStripMenuItem,
            this.cậpNhậtPhòngToolStripMenuItem});
            this.menu.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(193, 52);
            // 
            // thêmPhòngMớiToolStripMenuItem
            // 
            this.thêmPhòngMớiToolStripMenuItem.Name = "thêmPhòngMớiToolStripMenuItem";
            this.thêmPhòngMớiToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.thêmPhòngMớiToolStripMenuItem.Text = "Thêm phòng mới";
            this.thêmPhòngMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmPhòngMớiToolStripMenuItem_Click);
            // 
            // cậpNhậtPhòngToolStripMenuItem
            // 
            this.cậpNhậtPhòngToolStripMenuItem.Name = "cậpNhậtPhòngToolStripMenuItem";
            this.cậpNhậtPhòngToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.cậpNhậtPhòngToolStripMenuItem.Text = "Cập nhật phòng";
            this.cậpNhậtPhòngToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtPhòngToolStripMenuItem_Click);
            // 
            // cn_cmb
            // 
            this.cn_cmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cn_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cn_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cn_cmb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cn_cmb.FormattingEnabled = true;
            this.cn_cmb.ItemHeight = 30;
            this.cn_cmb.Location = new System.Drawing.Point(952, 12);
            this.cn_cmb.Name = "cn_cmb";
            this.cn_cmb.Size = new System.Drawing.Size(166, 36);
            this.cn_cmb.TabIndex = 17;
            // 
            // hopeRoundButton2
            // 
            this.hopeRoundButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeRoundButton2.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.hopeRoundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeRoundButton2.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeRoundButton2.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeRoundButton2.Enabled = false;
            this.hopeRoundButton2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeRoundButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeRoundButton2.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.hopeRoundButton2.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeRoundButton2.Location = new System.Drawing.Point(702, 12);
            this.hopeRoundButton2.Name = "hopeRoundButton2";
            this.hopeRoundButton2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRoundButton2.Size = new System.Drawing.Size(235, 40);
            this.hopeRoundButton2.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeRoundButton2.TabIndex = 18;
            this.hopeRoundButton2.Text = "Chọn chi nhánh";
            this.hopeRoundButton2.TextColor = System.Drawing.Color.White;
            this.hopeRoundButton2.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // LoadBtn
            // 
            this.LoadBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.LoadBtn.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.LoadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadBtn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.LoadBtn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoadBtn.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.LoadBtn.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.LoadBtn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.LoadBtn.Location = new System.Drawing.Point(1124, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.LoadBtn.Size = new System.Drawing.Size(183, 40);
            this.LoadBtn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.LoadBtn.TabIndex = 19;
            this.LoadBtn.Text = "Lấy dữ liệu";
            this.LoadBtn.TextColor = System.Drawing.Color.White;
            this.LoadBtn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // RoomManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 610);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.hopeRoundButton2);
            this.Controls.Add(this.cn_cmb);
            this.Controls.Add(this.UserView);
            this.Controls.Add(this.hopeRoundButton1);
            this.Name = "RoomManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomManage";
            this.Load += new System.EventHandler(this.RoomManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserView;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
        private ReaLTaiizor.Controls.MaterialContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem thêmPhòngMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtPhòngToolStripMenuItem;
        private ReaLTaiizor.Controls.HopeComboBox cn_cmb;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton2;
        private ReaLTaiizor.Controls.HopeRoundButton LoadBtn;
    }
}