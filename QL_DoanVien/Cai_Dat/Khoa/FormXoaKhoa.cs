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
    public partial class FormXoaKhoa : Form
    {
        public FormXoaKhoa()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        public void clear()
        {
            txtmaKhoa.Clear();
            txttenKhoa.Clear();
            txtmaKhoa.Focus();
        }
        private void txtmaKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var khoaquery = from k in db.Khoas
                                where k.MaKhoa == txtmaKhoa.Text
                                select k;
                Khoa khHienTai = khoaquery.SingleOrDefault();
                if (khHienTai != null)
                {
                    txttenKhoa.Text = khHienTai.TenKhoa;
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
            Khoa khoaXoa = db.Khoas.SingleOrDefault(khoa => khoa.MaKhoa == txtmaKhoa.Text);
            try
            {
                DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.Khoas.DeleteOnSubmit(khoaXoa);
                    db.SubmitChanges();
                    clear();
                }
                MessageBox.Show("Đã xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
