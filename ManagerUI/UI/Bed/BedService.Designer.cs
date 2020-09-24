namespace ManagerUI.UI.Bed
{
    partial class BedService
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
            this.menu = new ReaLTaiizor.Controls.MaterialContextMenuStrip();
            this.thêmDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.UserView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserView.Location = new System.Drawing.Point(0, 0);
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
            this.UserView.Size = new System.Drawing.Size(1038, 573);
            this.UserView.TabIndex = 17;
            this.UserView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserView_CellMouseDown);
            this.UserView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserView_MouseClick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menu.Depth = 0;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmDịchVụToolStripMenuItem,
            this.xoáDịchVụToolStripMenuItem});
            this.menu.MouseState = ReaLTaiizor.Helpers.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(211, 80);
            this.menu.Text = "menu";
            // 
            // thêmDịchVụToolStripMenuItem
            // 
            this.thêmDịchVụToolStripMenuItem.Name = "thêmDịchVụToolStripMenuItem";
            this.thêmDịchVụToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.thêmDịchVụToolStripMenuItem.Text = "Thêm dịch vụ";
            this.thêmDịchVụToolStripMenuItem.Click += new System.EventHandler(this.thêmDịchVụToolStripMenuItem_Click);
            // 
            // xoáDịchVụToolStripMenuItem
            // 
            this.xoáDịchVụToolStripMenuItem.Name = "xoáDịchVụToolStripMenuItem";
            this.xoáDịchVụToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xoáDịchVụToolStripMenuItem.Text = "Xoá dịch vụ";
            this.xoáDịchVụToolStripMenuItem.Click += new System.EventHandler(this.xoáDịchVụToolStripMenuItem_Click);
            // 
            // BedService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 573);
            this.Controls.Add(this.UserView);
            this.Name = "BedService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BedService";
            this.Load += new System.EventHandler(this.BedService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserView;
        private ReaLTaiizor.Controls.MaterialContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem thêmDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáDịchVụToolStripMenuItem;
    }
}