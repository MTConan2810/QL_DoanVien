using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DoanVien.Cai_Dat.LopHoc
{
    public partial class FormXoaLop : Form
    {
        public FormXoaLop()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();

        public void clear()
        {
            txtMalop.Clear();
            txtTenlop.Clear();
        }

        private void txtMalop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var lopquery = from l in db.Lops
                               where l.MaLop == txtMalop.Text
                               select l;
                Lop khHienTai = lopquery.SingleOrDefault();
                if (khHienTai != null)
                {
                    txtTenlop.Text = khHienTai.TenLop;
                }
                else
                {
                    MessageBox.Show("Lớp này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lop lophocXoa = db.Lops.SingleOrDefault(lop => lop.MaLop == txtMalop.Text);
            DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                db.Lops.DeleteOnSubmit(lophocXoa);
                db.SubmitChanges();
                clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
