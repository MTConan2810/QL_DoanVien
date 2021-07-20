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
    public partial class FormSuaKhoa : Form
    {
        public FormSuaKhoa()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Khoa khoaSUa = db.Khoas.SingleOrDefault(Khoa => Khoa.MaKhoa == txtmaKhoa.Text);

                khoaSUa.TenKhoa = txttenKhoa.Text;

                db.SubmitChanges();
                clear();
                MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
