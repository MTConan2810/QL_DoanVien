using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DoanVien.Cai_Dat
{
    public partial class FormSuaKHoc : Form
    {
        public FormSuaKHoc()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        public void clear()
        {
            txtmaKhoahoc.Clear();
            txttenKhoahoc.Clear();
            txtmaKhoahoc.Focus();
        }
        private void txtmaKhoahoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var khoaHocquery = from k in db.KhoaHocs
                                where k.MaKH == txtmaKhoahoc.Text
                                select k;
                KhoaHoc khHienTai = khoaHocquery.SingleOrDefault();
                if (khHienTai != null)
                {
                    txttenKhoahoc.Text = khHienTai.TenKH;
                }
                else
                {
                    MessageBox.Show("Khoa này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaHoc khoahocSUa = db.KhoaHocs.SingleOrDefault(Khoahoc => Khoahoc.MaKH == txtmaKhoahoc.Text);
                khoahocSUa.TenKH = txttenKhoahoc.Text;

                db.SubmitChanges();
                clear();
                MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
