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
    public partial class FormXoaKHoc : Form
    {
        public FormXoaKHoc()
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

        private void button1_Click(object sender, EventArgs e)
        {
            KhoaHoc khoahocXoa = db.KhoaHocs.SingleOrDefault(khoahoc => khoahoc.MaKH == txtmaKhoahoc.Text);

            try
            {
                DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.KhoaHocs.DeleteOnSubmit(khoahocXoa);
                    db.SubmitChanges();
                    clear();
                    MessageBox.Show("Đã Xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
