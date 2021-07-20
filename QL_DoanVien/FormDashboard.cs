using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DoanVien
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            var demdv = from dv in db.Students select dv;
            var sinhhoat = from dv in db.Students where dv.SinhHoat == true select dv;
            var sodoan = from dv in db.Students where dv.SoDoan == true select dv;
            var user = from us in db.Users select us;
            lblDV.Text = demdv.Count().ToString();
            lblSH.Text = sinhhoat.Count().ToString();
            lblSD.Text = sodoan.Count().ToString();
            lblUser.Text = user.Count().ToString();
            //biểu đồ                
            //chSinhHoat.DataSource = db.Students.ToList();
            //chSinhHoat.Series["BD1"].XValueMember = "HoTen"; 
            //chSinhHoat.Series["BD1"].YValueMembers = "SinhHoat";
            chSinhHoat.Series["BD1"].Points.AddXY("Đã Chuyển", sinhhoat.Count());
            chSinhHoat.Series["BD1"].Points.AddXY("Chưa chuyển",demdv.Count()-sinhhoat.Count());
            //biểu đồ sổ đoàn
            //chSoDoan.DataSource = db.Students.ToList();
            //chSoDoan.Series["BD2"].XValueMember = "HoTen";
            //chSoDoan.Series["BD2"].YValueMembers = "SoDoan";
            chSoDoan.Series["BD2"].Points.AddXY("Đã nộp", sodoan.Count());
            chSoDoan.Series["BD2"].Points.AddXY("Chưa nộp", demdv.Count() - sodoan.Count());


        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;          
            if (un.Role.TenRole != "Admin")
            {
                FormMain1 fm1 = new FormMain1();
                fm1.Tag = un;
                fm1.Show();
                this.Hide();
            }
            else
            {
                FormMain fm = new FormMain();
                fm.Tag = un;
                fm.Show();
                fm.Activate();
                this.Hide();
            }    
        }

        private void pbSutDown_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
