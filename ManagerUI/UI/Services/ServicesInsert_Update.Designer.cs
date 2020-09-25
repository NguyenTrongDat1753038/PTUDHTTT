namespace ManagerUI.UI.Services
{
    partial class ServicesInsert_Update
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
            this.groupBoxDV = new ReaLTaiizor.Controls.GroupBox();
            this.xoa_dv = new ReaLTaiizor.Controls.AloneCheckBox();
            this.id = new ReaLTaiizor.Controls.ForeverTextBox();
            this.skyLabel7 = new ReaLTaiizor.Controls.SkyLabel();
            this.cancel_Btn = new ReaLTaiizor.Controls.HopeButton();
            this.update_Btn = new ReaLTaiizor.Controls.HopeButton();
            this.create_Btn = new ReaLTaiizor.Controls.HopeButton();
            this.state = new ReaLTaiizor.Controls.SkyTextBox();
            this.length = new ReaLTaiizor.Controls.ForeverTextBox();
            this.timewait = new ReaLTaiizor.Controls.ForeverTextBox();
            this.price = new ReaLTaiizor.Controls.ForeverTextBox();
            this.description = new ReaLTaiizor.Controls.ForeverTextBox();
            this.name = new ReaLTaiizor.Controls.ForeverTextBox();
            this.skyLabel6 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel5 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.groupBoxDV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDV
            // 
            this.groupBoxDV.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDV.BackGColor = System.Drawing.Color.Azure;
            this.groupBoxDV.BaseColor = System.Drawing.Color.Transparent;
            this.groupBoxDV.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.groupBoxDV.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.groupBoxDV.Controls.Add(this.xoa_dv);
            this.groupBoxDV.Controls.Add(this.id);
            this.groupBoxDV.Controls.Add(this.skyLabel7);
            this.groupBoxDV.Controls.Add(this.cancel_Btn);
            this.groupBoxDV.Controls.Add(this.update_Btn);
            this.groupBoxDV.Controls.Add(this.create_Btn);
            this.groupBoxDV.Controls.Add(this.state);
            this.groupBoxDV.Controls.Add(this.length);
            this.groupBoxDV.Controls.Add(this.timewait);
            this.groupBoxDV.Controls.Add(this.price);
            this.groupBoxDV.Controls.Add(this.description);
            this.groupBoxDV.Controls.Add(this.name);
            this.groupBoxDV.Controls.Add(this.skyLabel6);
            this.groupBoxDV.Controls.Add(this.skyLabel5);
            this.groupBoxDV.Controls.Add(this.skyLabel4);
            this.groupBoxDV.Controls.Add(this.skyLabel3);
            this.groupBoxDV.Controls.Add(this.skyLabel2);
            this.groupBoxDV.Controls.Add(this.skyLabel1);
            this.groupBoxDV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.groupBoxDV.HeaderColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxDV.Location = new System.Drawing.Point(2, 3);
            this.groupBoxDV.MinimumSize = new System.Drawing.Size(136, 50);
            this.groupBoxDV.Name = "groupBoxDV";
            this.groupBoxDV.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.groupBoxDV.Size = new System.Drawing.Size(795, 445);
            this.groupBoxDV.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.groupBoxDV.TabIndex = 0;
            this.groupBoxDV.Text = "Thêm/Cập nhật dịch vụ";
            // 
            // xoa_dv
            // 
            this.xoa_dv.BackColor = System.Drawing.Color.White;
            this.xoa_dv.Checked = false;
            this.xoa_dv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoa_dv.EnabledCalc = true;
            this.xoa_dv.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_dv.ForeColor = System.Drawing.Color.Black;
            this.xoa_dv.Location = new System.Drawing.Point(550, 288);
            this.xoa_dv.Name = "xoa_dv";
            this.xoa_dv.Size = new System.Drawing.Size(141, 18);
            this.xoa_dv.TabIndex = 17;
            this.xoa_dv.Text = "Ngừng dịch vụ?";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.id.FocusOnHover = false;
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.id.Location = new System.Drawing.Point(193, 47);
            this.id.MaxLength = 32767;
            this.id.Multiline = false;
            this.id.Name = "id";
            this.id.ReadOnly = false;
            this.id.Size = new System.Drawing.Size(135, 34);
            this.id.TabIndex = 16;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id.UseSystemPasswordChar = false;
            // 
            // skyLabel7
            // 
            this.skyLabel7.AutoSize = true;
            this.skyLabel7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel7.Location = new System.Drawing.Point(50, 58);
            this.skyLabel7.Name = "skyLabel7";
            this.skyLabel7.Size = new System.Drawing.Size(101, 23);
            this.skyLabel7.TabIndex = 15;
            this.skyLabel7.Text = "ID dịch vụ";
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.cancel_Btn.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.cancel_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_Btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.cancel_Btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancel_Btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.cancel_Btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.cancel_Btn.Location = new System.Drawing.Point(621, 368);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.PrimaryColor = System.Drawing.Color.Moccasin;
            this.cancel_Btn.Size = new System.Drawing.Size(118, 46);
            this.cancel_Btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.cancel_Btn.TabIndex = 14;
            this.cancel_Btn.Text = "Hủy";
            this.cancel_Btn.TextColor = System.Drawing.Color.Black;
            this.cancel_Btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // update_Btn
            // 
            this.update_Btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.update_Btn.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.update_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_Btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.update_Btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.update_Btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_Btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.update_Btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.update_Btn.Location = new System.Drawing.Point(329, 368);
            this.update_Btn.Name = "update_Btn";
            this.update_Btn.PrimaryColor = System.Drawing.Color.Moccasin;
            this.update_Btn.Size = new System.Drawing.Size(176, 46);
            this.update_Btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.update_Btn.TabIndex = 13;
            this.update_Btn.Text = "Cập nhật dịch vụ";
            this.update_Btn.TextColor = System.Drawing.Color.Black;
            this.update_Btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.update_Btn.Click += new System.EventHandler(this.update_Btn_Click);
            // 
            // create_Btn
            // 
            this.create_Btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.create_Btn.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            this.create_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create_Btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.create_Btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.create_Btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_Btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.create_Btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.create_Btn.Location = new System.Drawing.Point(45, 368);
            this.create_Btn.Name = "create_Btn";
            this.create_Btn.PrimaryColor = System.Drawing.Color.Moccasin;
            this.create_Btn.Size = new System.Drawing.Size(168, 46);
            this.create_Btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.create_Btn.TabIndex = 12;
            this.create_Btn.Text = "Tạo dịch vụ";
            this.create_Btn.TextColor = System.Drawing.Color.Black;
            this.create_Btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.create_Btn.Click += new System.EventHandler(this.create_Btn_Click);
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.state.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.state.Location = new System.Drawing.Point(193, 277);
            this.state.MaxLength = 32767;
            this.state.MultiLine = false;
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(222, 34);
            this.state.TabIndex = 11;
            this.state.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.state.UseSystemPasswordChar = false;
            // 
            // length
            // 
            this.length.BackColor = System.Drawing.Color.Transparent;
            this.length.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.length.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.length.FocusOnHover = false;
            this.length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.length.Location = new System.Drawing.Point(592, 155);
            this.length.MaxLength = 32767;
            this.length.Multiline = false;
            this.length.Name = "length";
            this.length.ReadOnly = false;
            this.length.Size = new System.Drawing.Size(148, 34);
            this.length.TabIndex = 10;
            this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.length.UseSystemPasswordChar = false;
            // 
            // timewait
            // 
            this.timewait.BackColor = System.Drawing.Color.Transparent;
            this.timewait.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.timewait.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.timewait.FocusOnHover = false;
            this.timewait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.timewait.Location = new System.Drawing.Point(193, 155);
            this.timewait.MaxLength = 32767;
            this.timewait.Multiline = false;
            this.timewait.Name = "timewait";
            this.timewait.ReadOnly = false;
            this.timewait.Size = new System.Drawing.Size(174, 34);
            this.timewait.TabIndex = 9;
            this.timewait.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.timewait.UseSystemPasswordChar = false;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.price.FocusOnHover = false;
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.price.Location = new System.Drawing.Point(592, 97);
            this.price.MaxLength = 32767;
            this.price.Multiline = false;
            this.price.Name = "price";
            this.price.ReadOnly = false;
            this.price.Size = new System.Drawing.Size(148, 34);
            this.price.TabIndex = 8;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.price.UseSystemPasswordChar = false;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.description.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.description.FocusOnHover = false;
            this.description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.description.Location = new System.Drawing.Point(193, 215);
            this.description.MaxLength = 32767;
            this.description.Multiline = false;
            this.description.Name = "description";
            this.description.ReadOnly = false;
            this.description.Size = new System.Drawing.Size(546, 34);
            this.description.TabIndex = 7;
            this.description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.description.UseSystemPasswordChar = false;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.name.FocusOnHover = false;
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.name.Location = new System.Drawing.Point(193, 98);
            this.name.MaxLength = 32767;
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.ReadOnly = false;
            this.name.Size = new System.Drawing.Size(243, 34);
            this.name.TabIndex = 6;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.UseSystemPasswordChar = false;
            // 
            // skyLabel6
            // 
            this.skyLabel6.AutoSize = true;
            this.skyLabel6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel6.Location = new System.Drawing.Point(50, 288);
            this.skyLabel6.Name = "skyLabel6";
            this.skyLabel6.Size = new System.Drawing.Size(106, 23);
            this.skyLabel6.TabIndex = 5;
            this.skyLabel6.Text = "Tình trạng";
            // 
            // skyLabel5
            // 
            this.skyLabel5.AutoSize = true;
            this.skyLabel5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel5.Location = new System.Drawing.Point(471, 166);
            this.skyLabel5.Name = "skyLabel5";
            this.skyLabel5.Size = new System.Drawing.Size(115, 23);
            this.skyLabel5.TabIndex = 4;
            this.skyLabel5.Text = "Thời lượng";
            // 
            // skyLabel4
            // 
            this.skyLabel4.AutoSize = true;
            this.skyLabel4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel4.Location = new System.Drawing.Point(50, 166);
            this.skyLabel4.Name = "skyLabel4";
            this.skyLabel4.Size = new System.Drawing.Size(137, 23);
            this.skyLabel4.TabIndex = 3;
            this.skyLabel4.Text = "Thời gian chờ";
            // 
            // skyLabel3
            // 
            this.skyLabel3.AutoSize = true;
            this.skyLabel3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel3.Location = new System.Drawing.Point(546, 108);
            this.skyLabel3.Name = "skyLabel3";
            this.skyLabel3.Size = new System.Drawing.Size(40, 23);
            this.skyLabel3.TabIndex = 2;
            this.skyLabel3.Text = "Giá";
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel2.Location = new System.Drawing.Point(50, 226);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(60, 23);
            this.skyLabel2.TabIndex = 1;
            this.skyLabel2.Text = "Mô tả";
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel1.Location = new System.Drawing.Point(50, 108);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(115, 23);
            this.skyLabel1.TabIndex = 0;
            this.skyLabel1.Text = "Tên dịch vụ";
            // 
            // ServicesInsert_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDV);
            this.Name = "ServicesInsert_Update";
            this.Text = "ServicesInsert_Update";
            this.Load += new System.EventHandler(this.ServicesInsert_Update_Load);
            this.groupBoxDV.ResumeLayout(false);
            this.groupBoxDV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.GroupBox groupBoxDV;
        private ReaLTaiizor.Controls.SkyLabel skyLabel6;
        private ReaLTaiizor.Controls.SkyLabel skyLabel5;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox length;
        private ReaLTaiizor.Controls.ForeverTextBox timewait;
        private ReaLTaiizor.Controls.ForeverTextBox price;
        private ReaLTaiizor.Controls.ForeverTextBox description;
        private ReaLTaiizor.Controls.ForeverTextBox name;
        private ReaLTaiizor.Controls.SkyTextBox state;
        private ReaLTaiizor.Controls.HopeButton cancel_Btn;
        private ReaLTaiizor.Controls.HopeButton update_Btn;
        private ReaLTaiizor.Controls.HopeButton create_Btn;
        private ReaLTaiizor.Controls.ForeverTextBox id;
        private ReaLTaiizor.Controls.SkyLabel skyLabel7;
        private ReaLTaiizor.Controls.AloneCheckBox xoa_dv;
    }
}