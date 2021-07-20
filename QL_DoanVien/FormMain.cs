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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        List<string> list_detail;
        private void FormMain_Load(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            lblTenUser.Text = un.Name;
            //xét phân quyền
            list_detail = list_per(un.MaRole);
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs==DialogResult.OK)
            {
                FormLogin fl = new FormLogin();
                fl.Show();
                this.Hide();
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormUser fu = new FormUser();
            fu.Tag = un;
            fu.Show();
            this.Hide();

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            
            FormDashboard fdb = new FormDashboard();
            fdb.Tag = un;
            fdb.Show();
            this.Hide();
                    
        }
        //lấy chi tiết quyền hạn
        private List<string> list_per(string id_role)
        {
            List<string> termsList = new List<string>();          
            var quyen = from pq in db.PhanQuyens
                        where pq.MaRole.Equals(id_role)
                        select new
                        {
                            pq.MaRole,
                            pq.MaPMS,
                            pq.Permission.TenPMS
                        };
            
            foreach (var item in quyen)
            {
                termsList.Add(item.TenPMS);
            }
            return termsList;
        }
        public Boolean checkQuyen(string code)
        {
            Boolean check = false;
            foreach(string item in list_detail)
            {
                if(item == code)
                {
                    check = true;
                }    
            }
            return check;
            
        }
        private void btnDoanVien_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormQuanLyDoanVien fdb = new FormQuanLyDoanVien();
            fdb.Tag = un;
            fdb.Show();
            this.Hide();
        }

        private void BtnDoanPhi_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;

            FormDoanPhi fdb = new FormDoanPhi();
            fdb.Tag = un;
            fdb.Show();
            this.Hide();
        }

        private void btnChuyenSH_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;

            FormChuyenSH fdb = new FormChuyenSH();
            fdb.Tag = un;
            fdb.Show();
            this.Hide();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;

            FormQLLopHoc fdb = new FormQLLopHoc();
            fdb.Tag = un;
            fdb.Show();
            this.Hide();
        }
    }
}
