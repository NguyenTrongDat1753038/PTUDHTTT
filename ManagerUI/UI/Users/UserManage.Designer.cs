namespace ManagerUI.UI.Users
{
    partial class UserManage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserView = new System.Windows.Forms.DataGridView();
            this.menuUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.hopeGroupBox2 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.chuthich = new ReaLTaiizor.Controls.HopeRoundButton();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.load_btn = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).BeginInit();
            this.menuUser.SuspendLayout();
            this.hopeGroupBox2.SuspendLayout();
            this.hopeGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.UserView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UserView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.UserView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UserView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserView.ContextMenuStrip = this.menuUser;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserView.DefaultCellStyle = dataGridViewCellStyle7;
            this.UserView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserView.Location = new System.Drawing.Point(0, 66);
            this.UserView.MultiSelect = false;
            this.UserView.Name = "UserView";
            this.UserView.ReadOnly = true;
            this.UserView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.UserView.RowHeadersVisible = false;
            this.UserView.RowHeadersWidth = 51;
            this.UserView.RowTemplate.Height = 24;
            this.UserView.Size = new System.Drawing.Size(1568, 544);
            this.UserView.TabIndex = 5;
            this.UserView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserView_CellMouseDown);
            this.UserView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserView_MouseClick);
            // 
            // menuUser
            // 
            this.menuUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNgườiDùngToolStripMenuItem,
            this.xoáNgườiDùngToolStripMenuItem,
            this.cậpNhậtNgườiDùngToolStripMenuItem,
            this.xemThôngTinNgườiDùngToolStripMenuItem});
            this.menuUser.Name = "contextMenuStrip1";
            this.menuUser.Size = new System.Drawing.Size(254, 100);
            // 
            // thêmNgườiDùngToolStripMenuItem
            // 
            this.thêmNgườiDùngToolStripMenuItem.Name = "thêmNgườiDùngToolStripMenuItem";
            this.thêmNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.thêmNgườiDùngToolStripMenuItem.Text = "Thêm người dùng";
            this.thêmNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.thêmNgườiDùngToolStripMenuItem_Click);
            // 
            // xoáNgườiDùngToolStripMenuItem
            // 
            this.xoáNgườiDùngToolStripMenuItem.Name = "xoáNgườiDùngToolStripMenuItem";
            this.xoáNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.xoáNgườiDùngToolStripMenuItem.Text = "Xoá người dùng";
            this.xoáNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.xoáNgườiDùngToolStripMenuItem_Click);
            // 
            // cậpNhậtNgườiDùngToolStripMenuItem
            // 
            this.cậpNhậtNgườiDùngToolStripMenuItem.Name = "cậpNhậtNgườiDùngToolStripMenuItem";
            this.cậpNhậtNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.cậpNhậtNgườiDùngToolStripMenuItem.Text = "Cập nhật người dùng";
            this.cậpNhậtNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtNgườiDùngToolStripMenuItem_Click);
            // 
            // xemThôngTinNgườiDùngToolStripMenuItem
            // 
            this.xemThôngTinNgườiDùngToolStripMenuItem.Name = "xemThôngTinNgườiDùngToolStripMenuItem";
            this.xemThôngTinNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.xemThôngTinNgườiDùngToolStripMenuItem.Text = "Xem thông tin người dùng";
            this.xemThôngTinNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinNgườiDùngToolStripMenuItem_Click);
            // 
            // hopeComboBox1
            // 
            this.hopeComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeComboBox1.FormattingEnabled = true;
            this.hopeComboBox1.ItemHeight = 20;
            this.hopeComboBox1.Items.AddRange(new object[] {
            "1. Người dùng",
            "2. Nhân viên",
            "3. Bác sĩ",
            "4. Quản lí"});
            this.hopeComboBox1.Location = new System.Drawing.Point(77, 8);
            this.hopeComboBox1.Name = "hopeComboBox1";
            this.hopeComboBox1.Size = new System.Drawing.Size(169, 26);
            this.hopeComboBox1.TabIndex = 1;
            // 
            // foxLabel2
            // 
            this.foxLabel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel2.Location = new System.Drawing.Point(6, 8);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(65, 26);
            this.foxLabel2.TabIndex = 0;
            this.foxLabel2.Text = "Vai trò";
            // 
            // hopeGroupBox2
            // 
            this.hopeGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox2.Controls.Add(this.hopeComboBox1);
            this.hopeGroupBox2.Controls.Add(this.foxLabel2);
            this.hopeGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox2.Location = new System.Drawing.Point(1310, 6);
            this.hopeGroupBox2.Name = "hopeGroupBox2";
            this.hopeGroupBox2.ShowText = false;
            this.hopeGroupBox2.Size = new System.Drawing.Size(253, 40);
            this.hopeGroupBox2.TabIndex = 8;
            this.hopeGroupBox2.TabStop = false;
            this.hopeGroupBox2.Text = "hopeGroupBox2";
            this.hopeGroupBox2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // chuthich
            // 
            this.chuthich.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.chuthich.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.chuthich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chuthich.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.chuthich.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chuthich.Enabled = false;
            this.chuthich.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chuthich.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.chuthich.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.chuthich.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.chuthich.Location = new System.Drawing.Point(745, 6);
            this.chuthich.Name = "chuthich";
            this.chuthich.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.chuthich.Size = new System.Drawing.Size(208, 40);
            this.chuthich.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.chuthich.TabIndex = 6;
            this.chuthich.Text = "Chú thich";
            this.chuthich.TextColor = System.Drawing.Color.White;
            this.chuthich.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // foxLabel1
            // 
            this.foxLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(6, 11);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(105, 23);
            this.foxLabel1.TabIndex = 0;
            this.foxLabel1.Text = "Tình trạng";
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
            this.hopeRoundButton1.Location = new System.Drawing.Point(91, 6);
            this.hopeRoundButton1.Name = "hopeRoundButton1";
            this.hopeRoundButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRoundButton1.Size = new System.Drawing.Size(286, 40);
            this.hopeRoundButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeRoundButton1.TabIndex = 9;
            this.hopeRoundButton1.Text = "Quản lý người dùng";
            this.hopeRoundButton1.TextColor = System.Drawing.Color.White;
            this.hopeRoundButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // hopeGroupBox1
            // 
            this.hopeGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Controls.Add(this.materialLabel2);
            this.hopeGroupBox1.Controls.Add(this.materialLabel1);
            this.hopeGroupBox1.Controls.Add(this.foxLabel1);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(953, 6);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(357, 40);
            this.hopeGroupBox1.TabIndex = 7;
            this.hopeGroupBox1.TabStop = false;
            this.hopeGroupBox1.Text = "hopeGroupBox1";
            this.hopeGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(241, 11);
            this.materialLabel2.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "False: Đã khoá";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(117, 11);
            this.materialLabel1.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "True: Chưa khoá";
            // 
            // load_btn
            // 
            this.load_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.load_btn.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.load_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.load_btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.load_btn.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.load_btn.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.load_btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.load_btn.Location = new System.Drawing.Point(468, 6);
            this.load_btn.Name = "load_btn";
            this.load_btn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.load_btn.Size = new System.Drawing.Size(118, 40);
            this.load_btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.load_btn.TabIndex = 10;
            this.load_btn.Text = "Load";
            this.load_btn.TextColor = System.Drawing.Color.White;
            this.load_btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // UserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 610);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.UserView);
            this.Controls.Add(this.hopeGroupBox2);
            this.Controls.Add(this.chuthich);
            this.Controls.Add(this.hopeRoundButton1);
            this.Controls.Add(this.hopeGroupBox1);
            this.Name = "UserManage";
            this.Text = "UserManage";
            this.Load += new System.EventHandler(this.UserManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).EndInit();
            this.menuUser.ResumeLayout(false);
            this.hopeGroupBox2.ResumeLayout(false);
            this.hopeGroupBox1.ResumeLayout(false);
            this.hopeGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserView;
        private System.Windows.Forms.ContextMenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinNgườiDùngToolStripMenuItem;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox2;
        private ReaLTaiizor.Controls.HopeRoundButton chuthich;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.HopeRoundButton load_btn;
    }
}