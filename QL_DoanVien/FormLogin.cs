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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtuser.Focus();
        }
        QLDVDataContext db = new QLDVDataContext();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            User un = db.Users.SingleOrDefault(u => u.Username == txtuser.Text && u.Password == txtpass.Text);
            if(un!=null)
            {
                if(un.Role.TenRole.Equals("Admin"))
                {
                    FormMain fm = new FormMain();
                    fm.Tag = un;
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    FormMain1 fm1 = new FormMain1();
                    fm1.Tag = un;
                    fm1.Show();
                    this.Hide();
                }    
                
            }  
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear();
            }    
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender,e);
            }    
           
        }
    }
}
