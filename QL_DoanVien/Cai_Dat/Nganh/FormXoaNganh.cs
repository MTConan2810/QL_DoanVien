using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DoanVien.Cai_Dat.Nganh
{
    public partial class FormXoaNganh : Form
    {
        public FormXoaNganh()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtmaNganh.Clear();
            txttenNganh.Clear();
            cbxKhoa.ResetText();
            txtmaNganh.Focus();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void taoDScombo()
        {
            var tenKhoa = from tenkhoa in db.Khoas
                          select tenkhoa;
            cbxKhoa.DataSource = tenKhoa;
            cbxKhoa.DisplayMember = "TenKhoa";
            cbxKhoa.ValueMember = "MaKhoa";
        }
        private void FormXoaNganh_Load(object sender, EventArgs e)
        {
            taoDScombo();
        }

        private void txtmaNganh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var nganhquery = from ng in db.NganhHocs
                                 where ng.MaNganh == txtmaNganh.Text
                                 select ng;
                NganhHoc khHienTai = nganhquery.SingleOrDefault();
                if (khHienTai != null)
                {
                    txttenNganh.Text = khHienTai.TenNganh;
                    cbxKhoa.Text = khHienTai.Khoa.TenKhoa;
                }
                else
                {
                    MessageBox.Show("Ngành này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NganhHoc nganhXoa = db.NganhHocs.SingleOrDefault(nganh => nganh.MaNganh == txtmaNganh.Text);
                DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.NganhHocs.DeleteOnSubmit(nganhXoa);
                    db.SubmitChanges();
                    clear();
                }
                MessageBox.Show("Đã Xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
