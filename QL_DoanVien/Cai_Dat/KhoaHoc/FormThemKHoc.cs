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
    public partial class FormThemKHoc : Form
    {
        public FormThemKHoc()
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
        private void button1_Click(object sender, EventArgs e)
        {
            KhoaHoc kcheck = db.KhoaHocs.SingleOrDefault(u => u.MaKH == txtmaKhoahoc.Text);
            if (kcheck == null)
            {
                KhoaHoc khoahocMoi = new KhoaHoc();
                khoahocMoi.MaKH = txtmaKhoahoc.Text;
                khoahocMoi.TenKH = txttenKhoahoc.Text;
                khoahocMoi.LastCode = DateTime.Now.Year;
                db.KhoaHocs.InsertOnSubmit(khoahocMoi);
                db.SubmitChanges();
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Khoá học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
