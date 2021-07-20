using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DoanVien.Doan_vien
{
    public partial class FormXoa : Form
    {
        public FormXoa()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void txtMaSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var studentQuery = from k in db.Students
                                   where k.MaSV == txtMaSV.Text
                                   select k;
                Student a = studentQuery.SingleOrDefault();
                if (a != null)
                {
                    txtHoTen.Text = a.HoTen;
                    txtMaSV.Text = a.MaSV;
                    txtSDT.Text = a.DienThoai;                
                    txtLop.Text = a.Lop.TenLop;
                }
                else
                {
                    MessageBox.Show("Đoàn viên này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student dvXoa = db.Students.SingleOrDefault(khoa => khoa.MaSV == txtMaSV.Text);
            try
            {
                DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.Students.DeleteOnSubmit(dvXoa);
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
        public void clear()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtLop.Clear();
            txtSDT.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
