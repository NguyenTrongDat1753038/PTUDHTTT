namespace ManagerUI.UI.Appointment
{
    partial class ApmentInsert_Update_Details
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
            this.ctlh_dv = new System.Windows.Forms.DataGridView();
            this.contextMenuLH_DV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctlh_dv)).BeginInit();
            this.contextMenuLH_DV.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlh_dv
            // 
            this.ctlh_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlh_dv.Location = new System.Drawing.Point(12, 69);
            this.ctlh_dv.Name = "ctlh_dv";
            this.ctlh_dv.RowHeadersVisible = false;
            this.ctlh_dv.RowHeadersWidth = 51;
            this.ctlh_dv.RowTemplate.Height = 24;
            this.ctlh_dv.Size = new System.Drawing.Size(782, 376);
            this.ctlh_dv.TabIndex = 0;
            this.ctlh_dv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlh_dv_CellMouseDown);
            // 
            // contextMenuLH_DV
            // 
            this.contextMenuLH_DV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuLH_DV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaDịchVụToolStripMenuItem});
            this.contextMenuLH_DV.Name = "contextMenuLH_DV";
            this.contextMenuLH_DV.Size = new System.Drawing.Size(156, 28);
            // 
            // xóaDịchVụToolStripMenuItem
            // 
            this.xóaDịchVụToolStripMenuItem.Name = "xóaDịchVụToolStripMenuItem";
            this.xóaDịchVụToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
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
            this.hopeRoundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeRoundButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeRoundButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeRoundButton1.Location = new System.Drawing.Point(299, 25);
            this.hopeRoundButton1.Name = "hopeRoundButton1";
            this.hopeRoundButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRoundButton1.Size = new System.Drawing.Size(175, 38);
            this.hopeRoundButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeRoundButton1.TabIndex = 1;
            this.hopeRoundButton1.Text = "Thêm dịch vụ";
            this.hopeRoundButton1.TextColor = System.Drawing.Color.White;
            this.hopeRoundButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeRoundButton1.Click += new System.EventHandler(this.hopeRoundButton1_Click);
            // 
            // ApmentInsert_Update_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hopeRoundButton1);
            this.Controls.Add(this.ctlh_dv);
            this.Name = "ApmentInsert_Update_Details";
            this.Text = "ApmentInsert_Update_Details";
            this.Load += new System.EventHandler(this.ApmentInsert_Update_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlh_dv)).EndInit();
            this.contextMenuLH_DV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ctlh_dv;
        private System.Windows.Forms.ContextMenuStrip contextMenuLH_DV;
        private System.Windows.Forms.ToolStripMenuItem xóaDịchVụToolStripMenuItem;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
    }
}