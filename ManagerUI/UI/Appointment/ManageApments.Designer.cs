namespace ManagerUI.UI.Appointment
{
    partial class ManageApments
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
            this.LHview = new System.Windows.Forms.DataGridView();
            this.contextMenuLH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTiếtLịchHẹnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLịchHẹnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtLịchHẹnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaLịchHẹnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            this.CTLHview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LHview)).BeginInit();
            this.contextMenuLH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTLHview)).BeginInit();
            this.SuspendLayout();
            // 
            // LHview
            // 
            this.LHview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LHview.Location = new System.Drawing.Point(12, 107);
            this.LHview.Name = "LHview";
            this.LHview.ReadOnly = true;
            this.LHview.RowHeadersVisible = false;
            this.LHview.RowHeadersWidth = 51;
            this.LHview.RowTemplate.Height = 24;
            this.LHview.Size = new System.Drawing.Size(888, 494);
            this.LHview.TabIndex = 0;
            this.LHview.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LHview_CellMouseDown);
            // 
            // contextMenuLH
            // 
            this.contextMenuLH.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuLH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtLịchHẹnToolStripMenuItem,
            this.thêmLịchHẹnToolStripMenuItem,
            this.cậpNhậtLịchHẹnToolStripMenuItem,
            this.xóaLịchHẹnToolStripMenuItem});
            this.contextMenuLH.Name = "contextMenuLH";
            this.contextMenuLH.Size = new System.Drawing.Size(213, 100);
            // 
            // xemChiTiếtLịchHẹnToolStripMenuItem
            // 
            this.xemChiTiếtLịchHẹnToolStripMenuItem.Name = "xemChiTiếtLịchHẹnToolStripMenuItem";
            this.xemChiTiếtLịchHẹnToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.xemChiTiếtLịchHẹnToolStripMenuItem.Text = "Xem chi tiết lịch hẹn";
            this.xemChiTiếtLịchHẹnToolStripMenuItem.Click += new System.EventHandler(this.xemChiTiếtLịchHẹnToolStripMenuItem_Click);
            // 
            // thêmLịchHẹnToolStripMenuItem
            // 
            this.thêmLịchHẹnToolStripMenuItem.Name = "thêmLịchHẹnToolStripMenuItem";
            this.thêmLịchHẹnToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.thêmLịchHẹnToolStripMenuItem.Text = "Thêm lịch hẹn";
            this.thêmLịchHẹnToolStripMenuItem.Click += new System.EventHandler(this.thêmLịchHẹnToolStripMenuItem_Click);
            // 
            // cậpNhậtLịchHẹnToolStripMenuItem
            // 
            this.cậpNhậtLịchHẹnToolStripMenuItem.Name = "cậpNhậtLịchHẹnToolStripMenuItem";
            this.cậpNhậtLịchHẹnToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.cậpNhậtLịchHẹnToolStripMenuItem.Text = "Cập nhật lịch hẹn";
            this.cậpNhậtLịchHẹnToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtLịchHẹnToolStripMenuItem_Click);
            // 
            // xóaLịchHẹnToolStripMenuItem
            // 
            this.xóaLịchHẹnToolStripMenuItem.Name = "xóaLịchHẹnToolStripMenuItem";
            this.xóaLịchHẹnToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.xóaLịchHẹnToolStripMenuItem.Text = "Xóa lịch hẹn";
            this.xóaLịchHẹnToolStripMenuItem.Click += new System.EventHandler(this.xóaLịchHẹnToolStripMenuItem_Click);
            // 
            // hopeRoundButton1
            // 
            this.hopeRoundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeRoundButton1.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.hopeRoundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeRoundButton1.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeRoundButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeRoundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeRoundButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeRoundButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeRoundButton1.Location = new System.Drawing.Point(655, 60);
            this.hopeRoundButton1.Name = "hopeRoundButton1";
            this.hopeRoundButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRoundButton1.Size = new System.Drawing.Size(185, 41);
            this.hopeRoundButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeRoundButton1.TabIndex = 1;
            this.hopeRoundButton1.Text = "Load Lịch hẹn";
            this.hopeRoundButton1.TextColor = System.Drawing.Color.White;
            this.hopeRoundButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeRoundButton1.Click += new System.EventHandler(this.hopeRoundButton1_Click);
            // 
            // CTLHview
            // 
            this.CTLHview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTLHview.Location = new System.Drawing.Point(906, 107);
            this.CTLHview.Name = "CTLHview";
            this.CTLHview.RowHeadersWidth = 51;
            this.CTLHview.RowTemplate.Height = 24;
            this.CTLHview.Size = new System.Drawing.Size(650, 494);
            this.CTLHview.TabIndex = 2;
            // 
            // ManageApments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 610);
            this.Controls.Add(this.CTLHview);
            this.Controls.Add(this.hopeRoundButton1);
            this.Controls.Add(this.LHview);
            this.Name = "ManageApments";
            this.Text = "ManageApments";
            this.Load += new System.EventHandler(this.ManageApments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LHview)).EndInit();
            this.contextMenuLH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTLHview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LHview;
        private System.Windows.Forms.ContextMenuStrip contextMenuLH;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtLịchHẹnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLịchHẹnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtLịchHẹnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaLịchHẹnToolStripMenuItem;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
        private System.Windows.Forms.DataGridView CTLHview;
    }
}