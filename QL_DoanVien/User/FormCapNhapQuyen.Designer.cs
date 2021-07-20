
namespace QL_DoanVien
{
    partial class FormCapNhapQuyen
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
            this.cbxTenVT = new System.Windows.Forms.ComboBox();
            this.dataGridViewPQ = new System.Windows.Forms.DataGridView();
            this.chonquyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPQ)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTenVT
            // 
            this.cbxTenVT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbxTenVT.FormattingEnabled = true;
            this.cbxTenVT.Location = new System.Drawing.Point(87, 12);
            this.cbxTenVT.Name = "cbxTenVT";
            this.cbxTenVT.Size = new System.Drawing.Size(177, 24);
            this.cbxTenVT.TabIndex = 0;
            // 
            // dataGridViewPQ
            // 
            this.dataGridViewPQ.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chonquyen,
            this.quyen});
            this.dataGridViewPQ.Location = new System.Drawing.Point(42, 61);
            this.dataGridViewPQ.Name = "dataGridViewPQ";
            this.dataGridViewPQ.RowHeadersWidth = 51;
            this.dataGridViewPQ.RowTemplate.Height = 24;
            this.dataGridViewPQ.Size = new System.Drawing.Size(291, 472);
            this.dataGridViewPQ.TabIndex = 11;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCapNhapQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPQ);
            this.Controls.Add(this.cbxTenVT);
            this.Name = "FormCapNhapQuyen";
            this.Text = "FormCapNhapQuyen";
            this.Load += new System.EventHandler(this.FormCapNhapQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTenVT;
        private System.Windows.Forms.DataGridView dataGridViewPQ;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chonquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}