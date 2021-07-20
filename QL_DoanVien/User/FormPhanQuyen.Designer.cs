
namespace QL_DoanVien
{
    partial class FormPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhanQuyen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhanQuyen = new System.Windows.Forms.Label();
            this.TTTK = new System.Windows.Forms.Label();
            this.QLTK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewVT = new System.Windows.Forms.DataGridView();
            this.MaVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPQ = new System.Windows.Forms.DataGridView();
            this.chonquyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbSutdown = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSutdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.pbSutdown);
            this.groupBox1.Controls.Add(this.pbBack);
            this.groupBox1.Controls.Add(this.PhanQuyen);
            this.groupBox1.Controls.Add(this.TTTK);
            this.groupBox1.Controls.Add(this.QLTK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-12, -26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 713);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhanQuyen.Location = new System.Drawing.Point(24, 374);
            this.PhanQuyen.Name = "PhanQuyen";
            this.PhanQuyen.Size = new System.Drawing.Size(292, 47);
            this.PhanQuyen.TabIndex = 7;
            this.PhanQuyen.Text = "Phân quyền";
            this.PhanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PhanQuyen.Click += new System.EventHandler(this.PhanQuyen_Click);
            // 
            // TTTK
            // 
            this.TTTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTTK.Location = new System.Drawing.Point(24, 302);
            this.TTTK.Name = "TTTK";
            this.TTTK.Size = new System.Drawing.Size(292, 47);
            this.TTTK.TabIndex = 6;
            this.TTTK.Text = "Thông tin tài khoản";
            this.TTTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TTTK.Click += new System.EventHandler(this.TTTK_Click);
            // 
            // QLTK
            // 
            this.QLTK.BackColor = System.Drawing.Color.DodgerBlue;
            this.QLTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLTK.Location = new System.Drawing.Point(24, 236);
            this.QLTK.Name = "QLTK";
            this.QLTK.Size = new System.Drawing.Size(292, 47);
            this.QLTK.TabIndex = 5;
            this.QLTK.Text = "Quản lí tài khoản";
            this.QLTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QLTK.Click += new System.EventHandler(this.QLTK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "NGƯỜI DÙNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblVaiTro);
            this.groupBox2.Controls.Add(this.lblTen);
            this.groupBox2.Location = new System.Drawing.Point(24, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaiTro.Location = new System.Drawing.Point(99, 47);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(46, 18);
            this.lblVaiTro.TabIndex = 2;
            this.lblVaiTro.Text = "label2";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(99, 18);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(59, 20);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHÂN QUYỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã vai trò";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên vai trò";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(481, 128);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(175, 27);
            this.txtMa.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(481, 182);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(175, 27);
            this.txtTen.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vai Trò";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(863, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quyền hạn";
            // 
            // dataGridViewVT
            // 
            this.dataGridViewVT.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVT,
            this.TenVT});
            this.dataGridViewVT.Location = new System.Drawing.Point(331, 306);
            this.dataGridViewVT.Name = "dataGridViewVT";
            this.dataGridViewVT.RowHeadersWidth = 51;
            this.dataGridViewVT.RowTemplate.Height = 24;
            this.dataGridViewVT.Size = new System.Drawing.Size(427, 150);
            this.dataGridViewVT.TabIndex = 9;
            this.dataGridViewVT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVT_CellContentClick);
            // 
            // MaVT
            // 
            this.MaVT.HeaderText = "Mã vai trò";
            this.MaVT.MinimumWidth = 6;
            this.MaVT.Name = "MaVT";
            this.MaVT.Width = 150;
            // 
            // TenVT
            // 
            this.TenVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVT.HeaderText = "Tên vai trò";
            this.TenVT.MinimumWidth = 6;
            this.TenVT.Name = "TenVT";
            // 
            // dataGridViewPQ
            // 
            this.dataGridViewPQ.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chonquyen,
            this.quyen});
            this.dataGridViewPQ.Location = new System.Drawing.Point(782, 167);
            this.dataGridViewPQ.Name = "dataGridViewPQ";
            this.dataGridViewPQ.RowHeadersWidth = 51;
            this.dataGridViewPQ.RowTemplate.Height = 24;
            this.dataGridViewPQ.Size = new System.Drawing.Size(291, 472);
            this.dataGridViewPQ.TabIndex = 10;
            // 
            // chonquyen
            // 
            this.chonquyen.HeaderText = "";
            this.chonquyen.MinimumWidth = 6;
            this.chonquyen.Name = "chonquyen";
            this.chonquyen.Width = 50;
            // 
            // quyen
            // 
            this.quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quyen.HeaderText = "Các quyền";
            this.quyen.MinimumWidth = 6;
            this.quyen.Name = "quyen";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(369, 246);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 29);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm vai trò";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(519, 246);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(109, 29);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Olive;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(654, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(899, 122);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(174, 33);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load quyền hạn";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbSutdown
            // 
            this.pbSutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSutdown.Image = global::QL_DoanVien.Properties.Resources.shutdown_96px;
            this.pbSutdown.Location = new System.Drawing.Point(271, 637);
            this.pbSutdown.Name = "pbSutdown";
            this.pbSutdown.Size = new System.Drawing.Size(45, 35);
            this.pbSutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSutdown.TabIndex = 9;
            this.pbSutdown.TabStop = false;
            this.pbSutdown.Click += new System.EventHandler(this.pbSutdown_Click);
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::QL_DoanVien.Properties.Resources.arrow_left_96px;
            this.pbBack.Location = new System.Drawing.Point(24, 637);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(45, 35);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 8;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_DoanVien.Properties.Resources.logo_haui;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 651);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewPQ);
            this.Controls.Add(this.dataGridViewVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPhanQuyen";
            this.Text = "Hệ thống quản lí đoàn viên";
            this.Activated += new System.EventHandler(this.FormPhanQuyen_Activated);
            this.Load += new System.EventHandler(this.FormPhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSutdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbSutdown;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label PhanQuyen;
        private System.Windows.Forms.Label TTTK;
        private System.Windows.Forms.Label QLTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewVT;
        private System.Windows.Forms.DataGridView dataGridViewPQ;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chonquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
        private System.Windows.Forms.Button btnLoad;
    }
}