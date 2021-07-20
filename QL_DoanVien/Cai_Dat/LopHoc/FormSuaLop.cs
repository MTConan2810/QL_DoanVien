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
    public partial class FormSuaLop : Form
    {
        public FormSuaLop()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            Lop lophocSua = db.Lops.SingleOrDefault(lop => lop.MaLop == txtMalop.Text);
            try
            {
                lophocSua.TenLop = txtTenlop.Text;
                db.SubmitChanges();
                clear();
            }
            catch
            {
                MessageBox.Show("Chỉ được sửa tên", "Thông báo", MessageBoxButtons.OK);
            }
        }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSuaLop_Load(object sender, EventArgs e)
        {

        }
    }
}
