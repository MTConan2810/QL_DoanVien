
namespace QL_DoanVien
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chSinhHoat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSH = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSD = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.chSoDoan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSutDown = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chSinhHoat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chSoDoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSutDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-38, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(201, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hệ thống quản lí đoàn viên\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(199, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // chSinhHoat
            // 
            chartArea1.Name = "ChartArea1";
            this.chSinhHoat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chSinhHoat.Legends.Add(legend1);
            this.chSinhHoat.Location = new System.Drawing.Point(63, 384);
            this.chSinhHoat.Name = "chSinhHoat";
            this.chSinhHoat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "BD1";
            this.chSinhHoat.Series.Add(series1);
            this.chSinhHoat.Size = new System.Drawing.Size(350, 300);
            this.chSinhHoat.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Controls.Add(this.lblDV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(63, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đoàn viên";
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new System.Drawing.Point(64, 41);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(59, 20);
            this.lblDV.TabIndex = 0;
            this.lblDV.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.lblSH);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(281, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sinh hoạt";
            // 
            // lblSH
            // 
            this.lblSH.AutoSize = true;
            this.lblSH.Location = new System.Drawing.Point(61, 45);
            this.lblSH.Name = "lblSH";
            this.lblSH.Size = new System.Drawing.Size(59, 20);
            this.lblSH.TabIndex = 0;
            this.lblSH.Text = "label2";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lime;
            this.groupBox4.Controls.Add(this.lblSD);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(506, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sổ đoàn";
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(63, 45);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(59, 20);
            this.lblSD.TabIndex = 0;
            this.lblSD.Text = "label2";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox5.Controls.Add(this.lblUser);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(743, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Người dùng";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(64, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label2";
            // 
            // chSoDoan
            // 
            chartArea2.Name = "ChartArea1";
            this.chSoDoan.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chSoDoan.Legends.Add(legend2);
            this.chSoDoan.Location = new System.Drawing.Point(583, 384);
            this.chSoDoan.Name = "chSoDoan";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "BD2";
            this.chSoDoan.Series.Add(series2);
            this.chSoDoan.Size = new System.Drawing.Size(350, 300);
            this.chSoDoan.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Biểu đồ sinh viên chuyển sinh hoạt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Biểu đồ sinh viên nộp sổ đoàn";
            // 
            // pbSutDown
            // 
            this.pbSutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSutDown.Image = global::QL_DoanVien.Properties.Resources.shutdown_dark_96px;
            this.pbSutDown.Location = new System.Drawing.Point(931, 711);
            this.pbSutDown.Name = "pbSutDown";
            this.pbSutDown.Size = new System.Drawing.Size(45, 35);
            this.pbSutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSutDown.TabIndex = 11;
            this.pbSutDown.TabStop = false;
            this.pbSutDown.Click += new System.EventHandler(this.pbSutDown_Click);
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::QL_DoanVien.Properties.Resources.arrow_left_dark_96px;
            this.pbBack.Location = new System.Drawing.Point(12, 711);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(45, 35);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 10;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QL_DoanVien.Properties.Resources.logo_doan;
            this.pictureBox2.Location = new System.Drawing.Point(867, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_DoanVien.Properties.Resources.logo_haui;
            this.pictureBox1.Location = new System.Drawing.Point(49, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 752);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSutDown);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.chSoDoan);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chSinhHoat);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDashboard";
            this.Text = "Hệ thống quản lí đoàn viên";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chSinhHoat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chSoDoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSutDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSinhHoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSoDoan;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbSutDown;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.Label lblSH;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}