
namespace QL_DoanVien.Cai_Dat.LopHoc
{
    partial class FormThemLop
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
            this.cbxNganh = new System.Windows.Forms.ComboBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxNganh
            // 
            this.cbxNganh.FormattingEnabled = true;
            this.cbxNganh.Location = new System.Drawing.Point(161, 67);
            this.cbxNganh.Name = "cbxNganh";
            this.cbxNganh.Size = new System.Drawing.Size(374, 24);
            this.cbxNganh.TabIndex = 33;
            this.cbxNganh.DropDown += new System.EventHandler(this.cbxNganh_DropDown);
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(161, 22);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(374, 24);
            this.cbxKhoa.TabIndex = 32;
            this.cbxKhoa.DropDown += new System.EventHandler(this.cbxKhoa_DropDown);
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(162, 154);
            this.txtTenlop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(373, 22);
            this.txtTenlop.TabIndex = 31;
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(162, 110);
            this.txtMalop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(373, 22);
            this.txtMalop.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 159);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tên lớp học";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Mã lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tên Ngành";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tên Khoa";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(190, 223);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(318, 223);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 35);
            this.btnDong.TabIndex = 35;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 339);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxNganh);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "FormThemLop";
            this.Text = "Thêm lớp";
            this.Load += new System.EventHandler(this.FormThemLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxNganh;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
    }
}