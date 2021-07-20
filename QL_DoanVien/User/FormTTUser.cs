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
    public partial class FormTTUser : Form
    {
        public FormTTUser()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void QLTK_Click(object sender, EventArgs e)
        {
            QLTK.BackColor = Color.RoyalBlue;
            TTTK.BackColor = Color.DodgerBlue;
            PhanQuyen.BackColor = Color.DodgerBlue;
            User un = (User)this.Tag;
            FormUser fu = new FormUser();
            fu.Tag = un;
            fu.Show();
            this.Hide();
        }

        private void TTTK_Click(object sender, EventArgs e)
        {
            QLTK.BackColor = Color.DodgerBlue;
            TTTK.BackColor = Color.RoyalBlue;
            PhanQuyen.BackColor = Color.DodgerBlue;
        }

        private void PhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen.BackColor = Color.RoyalBlue;
            QLTK.BackColor = Color.DodgerBlue;
            TTTK.BackColor = Color.DodgerBlue;
            User un = (User)this.Tag;
            FormPhanQuyen fpq = new FormPhanQuyen();
            fpq.Tag = un;
            fpq.Show();
            this.Hide();
        }

        private void FormTTUser_Load(object sender, EventArgs e)
        {
            TTTK_Click(sender, e);
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            lblTK.Text = un.Username;
            lblHoTen.Text = un.Name;
            lblDV.Text = un.Khoa.TenKhoa;
            lblVT.Text = un.Role.TenRole;
            txtUser.Text = un.Username;
            txtName.Text = un.Name;
            cbxDv.Text = un.Khoa.TenKhoa;
            cbxVT.Text = un.Role.TenRole;
            if(lblVaiTro.Text!="Admin")
            {
                QLTK.Visible = false;
                PhanQuyen.Visible = false;
            }    
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            User uckeck = db.Users.SingleOrDefault(u => u.Username == txtUser.Text);
            if(txtpass.Text.Equals(uckeck.Password))
            {
                uckeck.Name = txtName.Text;
                uckeck.Password = txtpassag.Text;
                db.SubmitChanges();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            else
            {
                MessageBox.Show("Mật khẩu cũ sai, Mời bạn nhập lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (lblVaiTro.Text != "Admin")
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

        private void pbSutdown_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
