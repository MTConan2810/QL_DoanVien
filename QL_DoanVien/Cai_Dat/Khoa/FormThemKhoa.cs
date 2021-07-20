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
    public partial class FormThemKhoa : Form
    {
        public FormThemKhoa()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            Khoa kcheck = db.Khoas.SingleOrDefault(u => u.MaKhoa == txtmaKhoa.Text);
            if (kcheck == null)
            {
                Khoa khoaMoi = new Khoa();
                khoaMoi.MaKhoa = txtmaKhoa.Text;
                khoaMoi.TenKhoa = txttenKhoa.Text;
                db.Khoas.InsertOnSubmit(khoaMoi);
                db.SubmitChanges();
                clear();
                MessageBox.Show("Đã Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Khoa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clear()
        {
            txtmaKhoa.Clear();
            txttenKhoa.Clear();
            txtmaKhoa.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemKhoa_Load(object sender, EventArgs e)
        {

        }
    }
}
