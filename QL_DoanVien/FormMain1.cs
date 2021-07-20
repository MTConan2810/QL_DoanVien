using QL_DoanVien.Cai_Dat;
using QL_DoanVien.Cai_Dat.LopHoc;
using QL_DoanVien.Cai_Dat.Nganh;
using QL_DoanVien.Doan_vien;
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
    public partial class FormMain1 : Form
    {
        public FormMain1()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        List<string> list_detail;
        private void FormMain1_Load(object sender, EventArgs e)
        {
            menuStrip1.Cursor = Cursors.Hand;
            User un = (User)this.Tag;
            TaiKhoanMenu.Text = un.Name;
            //xét phân quyền
            
            list_detail = list_per(un.MaRole);
        }
        //lấy danh sách quyền
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
        //check danh sách quyền
        public Boolean checkQuyen(string code)
        {
            Boolean check = false;
            foreach (string item in list_detail)
            {
                if (item == code)
                {
                    check = true;
                }
            }
            return check;
        }

        private void LogoutMenu_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                FormLogin fl = new FormLogin();
                fl.Show();
                this.Hide();
            }
        }

        private void TTTKMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormTTUser fttu = new FormTTUser();
            fttu.Tag = un;
            fttu.Show();
            this.Hide();
        }

        private void DashboardMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("View Dashboard") == true)
            {
                FormDashboard fdb = new FormDashboard();
                fdb.Tag = un;
                fdb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XemDVMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if(checkQuyen("View Đoàn Viên") ==true)
            {
                FormQuanLyDoanVien fdb = new FormQuanLyDoanVien();
                fdb.Tag = un;
                fdb.Show();
                this.Hide();
            }   
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void ThemDvMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Thêm đoàn viên") == true)
            {
                FormThem fdb = new FormThem();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SuaDVMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Sửa đoàn viên") == true)
            {
                FormSuaDV fdb = new FormSuaDV();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XoaDVMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Xoá đoàn viên") == true)
            {
                FormXoa fdb = new FormXoa();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DoanPhiMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("View Đoàn phí") == true)
            {
                FormDoanPhi fdb = new FormDoanPhi();
                fdb.Tag = un;
                fdb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SinhHoatMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("View Chuyển sinh hoạt") == true)
            {
                FormChuyenSH fdb = new FormChuyenSH();
                fdb.Tag = un;
                fdb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XemLopMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("View Lớp") == true)
            {
                FormQLLopHoc fdb = new FormQLLopHoc();
                fdb.Tag = un;
                fdb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThemLopMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Thêm Lớp") == true)
            {
                FormThemLop fdb = new FormThemLop();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SuaLopMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Sửa Lớp") == true)
            {
                FormSuaLop fdb = new FormSuaLop();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XoaLopMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Xoá Lớp") == true)
            {
                FormXoaLop fdb = new FormXoaLop();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XemNganhMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("View Ngành") == true)
            {
                FormQLNganh fdb = new FormQLNganh();
                fdb.Tag = un;
                fdb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThemNganhMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Thêm Ngành") == true)
            {
                FormThemNganh fdb = new FormThemNganh();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SuaNganhMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Sửa Ngành") == true)
            {
                FormSuaNganh fdb = new FormSuaNganh();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XoaNganhMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Xoá Ngành") == true)
            {
                FormXoaNganh fdb = new FormXoaNganh();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XemKhoaMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("View Khoa") == true)
            {
                FormQLKhoa fdb = new FormQLKhoa();
                fdb.Tag = un;
                fdb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThemKhoaMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Thêm Khoa") == true)
            {
                FormThemKhoa fdb = new FormThemKhoa();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SuaKhoaMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Sửa Khoa") == true)
            {
                FormSuaKhoa fdb = new FormSuaKhoa();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XoaKhoaMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Xoá Khoa") == true)
            {
                FormXoaKhoa fdb = new FormXoaKhoa();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XemKhoaHocMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("View Khoá học") == true)
            {
                FormQLKhoaHoc fdb = new FormQLKhoaHoc();
                fdb.Tag = un;
                fdb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThemKhoaHocMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Thêm Khoá Học") == true)
            {
                FormThemKHoc fdb = new FormThemKHoc();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SuaKhoaHocMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Sửa Khoá học") == true)
            {
                FormSuaKHoc fdb = new FormSuaKHoc();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XoaKhoaHocMenu_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (checkQuyen("Xoá Khoá học") == true)
            {
                FormXoaKHoc fdb = new FormXoaKHoc();
                fdb.Tag = un;
                fdb.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần quyên truy cập, xin liên hệ tới admin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
