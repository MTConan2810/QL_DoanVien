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
    public partial class FormThemNganh : Form
    {
        public FormThemNganh()
        {
            InitializeComponent();
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
        private void FormThemNganh_Load(object sender, EventArgs e)
        {
            taoDScombo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NganhHoc ncheck = db.NganhHocs.SingleOrDefault(u => u.MaNganh == txtmaNganh.Text);
            if (ncheck == null)
            {
                NganhHoc nganhMoi = new NganhHoc();
                nganhMoi.MaNganh = txtmaNganh.Text;
                nganhMoi.TenNganh = txttenNganh.Text;
                nganhMoi.MaKhoa = cbxKhoa.SelectedValue.ToString();
                db.NganhHocs.InsertOnSubmit(nganhMoi);
                db.SubmitChanges();
                clear();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ngành đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear()
        {
            txtmaNganh.Clear();
            txttenNganh.Clear();
            cbxKhoa.ResetText();
            txtmaNganh.Focus();
        }
    }
}
