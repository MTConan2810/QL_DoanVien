
namespace QL_DoanVien.Cai_Dat.Nganh
{
    partial class FormSuaNganh
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
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttenNganh = new System.Windows.Forms.TextBox();
            this.txtmaNganh = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(205, 181);
            this.cbxKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(400, 24);
            this.cbxKhoa.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Khoa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tên ngành học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mã ngành học";
            // 
            // txttenNganh
            // 
            this.txttenNganh.Location = new System.Drawing.Point(205, 111);
            this.txttenNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txttenNganh.Name = "txttenNganh";
            this.txttenNganh.Size = new System.Drawing.Size(401, 22);
            this.txttenNganh.TabIndex = 9;
            // 
            // txtmaNganh
            // 
            this.txtmaNganh.Location = new System.Drawing.Point(205, 42);
            this.txtmaNganh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaNganh.Name = "txtmaNganh";
            this.txtmaNganh.Size = new System.Drawing.Size(401, 22);
            this.txtmaNganh.TabIndex = 8;
            this.txtmaNganh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmaNganh_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 39;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 38;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSuaNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttenNganh);
            this.Controls.Add(this.txtmaNganh);
            this.Name = "FormSuaNganh";
            this.Text = "Sửa ngành";
            this.Load += new System.EventHandler(this.FormSuaNganh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttenNganh;
        private System.Windows.Forms.TextBox txtmaNganh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}