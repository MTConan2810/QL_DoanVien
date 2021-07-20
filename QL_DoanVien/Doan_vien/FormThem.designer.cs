namespace QL_DoanVien
{
    partial class FormThem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThem));
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.pickNgayVaoDoan = new System.Windows.Forms.DateTimePicker();
            this.cbNganhHoc = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.cbSinhHoat = new System.Windows.Forms.ComboBox();
            this.cbXaPhuong = new System.Windows.Forms.ComboBox();
            this.cbTinh = new System.Windows.Forms.ComboBox();
            this.pickNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cbLopHoc = new System.Windows.Forms.ComboBox();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.cbSoDoan = new System.Windows.Forms.ComboBox();
            this.cbQuanHuyen = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(685, 68);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(301, 22);
            this.txtSDT.TabIndex = 133;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // pickNgayVaoDoan
            // 
            this.pickNgayVaoDoan.Location = new System.Drawing.Point(685, 116);
            this.pickNgayVaoDoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pickNgayVaoDoan.Name = "pickNgayVaoDoan";
            this.pickNgayVaoDoan.Size = new System.Drawing.Size(301, 22);
            this.pickNgayVaoDoan.TabIndex = 132;
            // 
            // cbNganhHoc
            // 
            this.cbNganhHoc.FormattingEnabled = true;
            this.cbNganhHoc.Location = new System.Drawing.Point(685, 361);
            this.cbNganhHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNganhHoc.Name = "cbNganhHoc";
            this.cbNganhHoc.Size = new System.Drawing.Size(301, 24);
            this.cbNganhHoc.TabIndex = 131;
            this.cbNganhHoc.DropDown += new System.EventHandler(this.cbNganhHoc_DropDown);
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(685, 311);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(301, 24);
            this.cbKhoa.TabIndex = 130;
            this.cbKhoa.DropDown += new System.EventHandler(this.cbKhoa_DropDown);
            // 
            // cbSinhHoat
            // 
            this.cbSinhHoat.FormattingEnabled = true;
            this.cbSinhHoat.Items.AddRange(new object[] {
            "Chưa Chuyển ",
            "Đã Chuyển"});
            this.cbSinhHoat.Location = new System.Drawing.Point(685, 262);
            this.cbSinhHoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSinhHoat.Name = "cbSinhHoat";
            this.cbSinhHoat.Size = new System.Drawing.Size(301, 24);
            this.cbSinhHoat.TabIndex = 129;
            // 
            // cbXaPhuong
            // 
            this.cbXaPhuong.FormattingEnabled = true;
            this.cbXaPhuong.Location = new System.Drawing.Point(176, 412);
            this.cbXaPhuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbXaPhuong.Name = "cbXaPhuong";
            this.cbXaPhuong.Size = new System.Drawing.Size(287, 24);
            this.cbXaPhuong.TabIndex = 128;
            this.cbXaPhuong.DropDown += new System.EventHandler(this.cbXaPhuong_DropDown);
            // 
            // cbTinh
            // 
            this.cbTinh.FormattingEnabled = true;
            this.cbTinh.Location = new System.Drawing.Point(176, 315);
            this.cbTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTinh.Name = "cbTinh";
            this.cbTinh.Size = new System.Drawing.Size(287, 24);
            this.cbTinh.TabIndex = 127;
            this.cbTinh.DropDown += new System.EventHandler(this.cbTinh_DropDown);
            // 
            // pickNgaySinh
            // 
            this.pickNgaySinh.Location = new System.Drawing.Point(176, 167);
            this.pickNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pickNgaySinh.Name = "pickNgaySinh";
            this.pickNgaySinh.Size = new System.Drawing.Size(287, 22);
            this.pickNgaySinh.TabIndex = 126;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(176, 116);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(287, 22);
            this.txtMaSV.TabIndex = 125;
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.Location = new System.Drawing.Point(685, 410);
            this.cbLopHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.Size = new System.Drawing.Size(301, 24);
            this.cbLopHoc.TabIndex = 124;
            this.cbLopHoc.DropDown += new System.EventHandler(this.cbLopHoc_DropDown);
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(685, 209);
            this.cbKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(301, 24);
            this.cbKhoaHoc.TabIndex = 123;
            // 
            // cbSoDoan
            // 
            this.cbSoDoan.FormattingEnabled = true;
            this.cbSoDoan.Items.AddRange(new object[] {
            "Chưa Nộp",
            "Đã Nộp"});
            this.cbSoDoan.Location = new System.Drawing.Point(685, 160);
            this.cbSoDoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSoDoan.Name = "cbSoDoan";
            this.cbSoDoan.Size = new System.Drawing.Size(301, 24);
            this.cbSoDoan.TabIndex = 122;
            // 
            // cbQuanHuyen
            // 
            this.cbQuanHuyen.FormattingEnabled = true;
            this.cbQuanHuyen.Location = new System.Drawing.Point(176, 363);
            this.cbQuanHuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQuanHuyen.Name = "cbQuanHuyen";
            this.cbQuanHuyen.Size = new System.Drawing.Size(287, 24);
            this.cbQuanHuyen.TabIndex = 121;
            this.cbQuanHuyen.DropDown += new System.EventHandler(this.cbQuanHuyen_DropDown);
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Sinh Viên",
            "Lớp Trưởng",
            "Bí Thư"});
            this.cbChucVu.Location = new System.Drawing.Point(176, 265);
            this.cbChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(287, 24);
            this.cbChucVu.TabIndex = 120;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(176, 215);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(287, 24);
            this.cbGioiTinh.TabIndex = 119;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(176, 73);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(287, 22);
            this.txtHoTen.TabIndex = 118;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(604, 416);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 17);
            this.label17.TabIndex = 117;
            this.label17.Text = "Lớp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(604, 318);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 17);
            this.label16.TabIndex = 116;
            this.label16.Text = "Khoa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(565, 268);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 115;
            this.label15.Text = "Sinh Hoạt";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 417);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 114;
            this.label14.Text = "Xã / Phường";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 319);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 113;
            this.label13.Text = "Tỉnh / TP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(527, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 112;
            this.label12.Text = "Ngày Vào Đoàn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(587, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 111;
            this.label11.Text = "Số ĐT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 110;
            this.label10.Text = "Mã Sinh Viên";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 367);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 109;
            this.label9.Text = "Ngành";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 108;
            this.label8.Text = "Khóa ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 107;
            this.label7.Text = "Sổ Đoàn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 106;
            this.label6.Text = "Quận / Huyện";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "Chức Vụ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 104;
            this.label4.Text = "Ngày Sinh";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Giới Tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Tên SV";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(839, 498);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 36);
            this.btnLuu.TabIndex = 101;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Red;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(113, 498);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 36);
            this.btnDong.TabIndex = 100;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 134;
            this.label1.Text = "ĐOÀN VIÊN";
            // 
            // FormThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.pickNgayVaoDoan);
            this.Controls.Add(this.cbNganhHoc);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.cbSinhHoat);
            this.Controls.Add(this.cbXaPhuong);
            this.Controls.Add(this.cbTinh);
            this.Controls.Add(this.pickNgaySinh);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.cbLopHoc);
            this.Controls.Add(this.cbKhoaHoc);
            this.Controls.Add(this.cbSoDoan);
            this.Controls.Add(this.cbQuanHuyen);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormThem";
            this.Text = "Thêm Đoàn Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker pickNgayVaoDoan;
        private System.Windows.Forms.ComboBox cbNganhHoc;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbSinhHoat;
        private System.Windows.Forms.ComboBox cbXaPhuong;
        private System.Windows.Forms.ComboBox cbTinh;
        private System.Windows.Forms.DateTimePicker pickNgaySinh;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cbLopHoc;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.ComboBox cbSoDoan;
        private System.Windows.Forms.ComboBox cbQuanHuyen;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
    }
}