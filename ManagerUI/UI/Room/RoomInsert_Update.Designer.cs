namespace ManagerUI.UI.Room
{
    partial class RoomInsert_Update
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
            this.groupBox1 = new ReaLTaiizor.Controls.GroupBox();
            this.chuthich = new ReaLTaiizor.Controls.ForeverTextBox();
            this.loai = new ReaLTaiizor.Controls.ForeverComboBox();
            this.idp = new ReaLTaiizor.Controls.ForeverTextBox();
            this.skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            this.mota = new ReaLTaiizor.Controls.ForeverTextBox();
            this.skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            this.update_btn = new ReaLTaiizor.Controls.HopeButton();
            this.cancel_btn = new ReaLTaiizor.Controls.HopeButton();
            this.insert_btn = new ReaLTaiizor.Controls.HopeButton();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.idcn = new ReaLTaiizor.Controls.ForeverComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackGColor = System.Drawing.Color.Azure;
            this.groupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.groupBox1.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBox1.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.groupBox1.Controls.Add(this.idcn);
            this.groupBox1.Controls.Add(this.chuthich);
            this.groupBox1.Controls.Add(this.loai);
            this.groupBox1.Controls.Add(this.idp);
            this.groupBox1.Controls.Add(this.skyLabel3);
            this.groupBox1.Controls.Add(this.mota);
            this.groupBox1.Controls.Add(this.skyLabel4);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.insert_btn);
            this.groupBox1.Controls.Add(this.skyLabel2);
            this.groupBox1.Controls.Add(this.skyLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.groupBox1.HeaderColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "Thêm/ Cập nhật phòng";
            // 
            // chuthich
            // 
            this.chuthich.BackColor = System.Drawing.Color.Transparent;
            this.chuthich.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.chuthich.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.chuthich.FocusOnHover = false;
            this.chuthich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chuthich.Location = new System.Drawing.Point(461, 128);
            this.chuthich.MaxLength = 32767;
            this.chuthich.Multiline = false;
            this.chuthich.Name = "chuthich";
            this.chuthich.ReadOnly = true;
            this.chuthich.Size = new System.Drawing.Size(196, 34);
            this.chuthich.TabIndex = 23;
            this.chuthich.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.chuthich.UseSystemPasswordChar = false;
            this.chuthich.TextChanged += new System.EventHandler(this.chuthich_TextChanged);
            // 
            // loai
            // 
            this.loai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.loai.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.loai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loai.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.loai.ForeColor = System.Drawing.Color.White;
            this.loai.FormattingEnabled = true;
            this.loai.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.loai.HoverFontColor = System.Drawing.Color.White;
            this.loai.ItemHeight = 18;
            this.loai.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.loai.Location = new System.Drawing.Point(313, 131);
            this.loai.Name = "loai";
            this.loai.Size = new System.Drawing.Size(121, 24);
            this.loai.TabIndex = 22;
            this.loai.SelectedIndexChanged += new System.EventHandler(this.foreverComboBox1_SelectedIndexChanged);
            // 
            // idp
            // 
            this.idp.BackColor = System.Drawing.Color.Transparent;
            this.idp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.idp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.idp.FocusOnHover = false;
            this.idp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.idp.Location = new System.Drawing.Point(313, 83);
            this.idp.MaxLength = 32767;
            this.idp.Multiline = false;
            this.idp.Name = "idp";
            this.idp.ReadOnly = true;
            this.idp.Size = new System.Drawing.Size(344, 34);
            this.idp.TabIndex = 21;
            this.idp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idp.UseSystemPasswordChar = false;
            // 
            // skyLabel3
            // 
            this.skyLabel3.AutoSize = true;
            this.skyLabel3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel3.Location = new System.Drawing.Point(81, 83);
            this.skyLabel3.Name = "skyLabel3";
            this.skyLabel3.Size = new System.Drawing.Size(111, 28);
            this.skyLabel3.TabIndex = 20;
            this.skyLabel3.Text = "ID Phòng";
            // 
            // mota
            // 
            this.mota.BackColor = System.Drawing.Color.Transparent;
            this.mota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.mota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.mota.FocusOnHover = false;
            this.mota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mota.Location = new System.Drawing.Point(313, 182);
            this.mota.MaxLength = 32767;
            this.mota.Multiline = false;
            this.mota.Name = "mota";
            this.mota.ReadOnly = false;
            this.mota.Size = new System.Drawing.Size(344, 34);
            this.mota.TabIndex = 15;
            this.mota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mota.UseSystemPasswordChar = false;
            // 
            // skyLabel4
            // 
            this.skyLabel4.AutoSize = true;
            this.skyLabel4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel4.Location = new System.Drawing.Point(81, 43);
            this.skyLabel4.Name = "skyLabel4";
            this.skyLabel4.Size = new System.Drawing.Size(152, 28);
            this.skyLabel4.TabIndex = 11;
            this.skyLabel4.Text = "ID Chi nhánh";
            // 
            // update_btn
            // 
            this.update_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.update_btn.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.update_btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.update_btn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.update_btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.update_btn.Location = new System.Drawing.Point(269, 336);
            this.update_btn.Name = "update_btn";
            this.update_btn.PrimaryColor = System.Drawing.Color.Moccasin;
            this.update_btn.Size = new System.Drawing.Size(234, 56);
            this.update_btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Cập nhật phòng";
            this.update_btn.TextColor = System.Drawing.Color.Black;
            this.update_btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // cancel_btn
            // 
            this.cancel_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.cancel_btn.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.cancel_btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancel_btn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.cancel_btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.cancel_btn.Location = new System.Drawing.Point(554, 336);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.PrimaryColor = System.Drawing.Color.Moccasin;
            this.cancel_btn.Size = new System.Drawing.Size(234, 56);
            this.cancel_btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Huỷ";
            this.cancel_btn.TextColor = System.Drawing.Color.Black;
            this.cancel_btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // insert_btn
            // 
            this.insert_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.insert_btn.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.insert_btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.insert_btn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.insert_btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.insert_btn.Location = new System.Drawing.Point(10, 336);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.PrimaryColor = System.Drawing.Color.Moccasin;
            this.insert_btn.Size = new System.Drawing.Size(234, 56);
            this.insert_btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.insert_btn.TabIndex = 4;
            this.insert_btn.Text = "Thêm phòng";
            this.insert_btn.TextColor = System.Drawing.Color.Black;
            this.insert_btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel2.Location = new System.Drawing.Point(81, 188);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(73, 28);
            this.skyLabel2.TabIndex = 1;
            this.skyLabel2.Text = "Mô tả";
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel1.Location = new System.Drawing.Point(81, 128);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(133, 28);
            this.skyLabel1.TabIndex = 0;
            this.skyLabel1.Text = "Loại phòng";
            // 
            // idcn
            // 
            this.idcn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.idcn.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.idcn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idcn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idcn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idcn.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.idcn.ForeColor = System.Drawing.Color.White;
            this.idcn.FormattingEnabled = true;
            this.idcn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.idcn.HoverFontColor = System.Drawing.Color.White;
            this.idcn.ItemHeight = 18;
            this.idcn.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.idcn.Location = new System.Drawing.Point(313, 43);
            this.idcn.Name = "idcn";
            this.idcn.Size = new System.Drawing.Size(181, 24);
            this.idcn.TabIndex = 24;
            // 
            // RoomInsert_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomInsert_Update";
            this.Text = "RoomInsert_Update";
            this.Load += new System.EventHandler(this.RoomInsert_Update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.GroupBox groupBox1;
        private ReaLTaiizor.Controls.ForeverTextBox idp;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private ReaLTaiizor.Controls.ForeverTextBox mota;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private ReaLTaiizor.Controls.HopeButton update_btn;
        private ReaLTaiizor.Controls.HopeButton cancel_btn;
        private ReaLTaiizor.Controls.HopeButton insert_btn;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox chuthich;
        private ReaLTaiizor.Controls.ForeverComboBox loai;
        private ReaLTaiizor.Controls.ForeverComboBox idcn;
    }
}