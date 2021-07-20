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
    public partial class FormThemLop : Form
    {
        public FormThemLop()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void cbxKhoa_DropDown(object sender, EventArgs e)
        {
            var khoaQuery = from khoa in db.Khoas
                            select khoa;
            cbxKhoa.DataSource = khoaQuery;
            cbxKhoa.DisplayMember = "TenKhoa";
            cbxKhoa.ValueMember = "MaKhoa";
        }

        private void cbxNganh_DropDown(object sender, EventArgs e)
        {
            var nganhQuery = from nganh in db.NganhHocs
                             where nganh.MaKhoa == cbxKhoa.SelectedValue.ToString()
                             select nganh;
            cbxNganh.DataSource = nganhQuery;
            cbxNganh.DisplayMember = "TenNganh";
            cbxNganh.ValueMember = "MaNganh";
        }
        private void setcbx()
        {
            var nganhQuery = from ng in db.NganhHocs
                             select ng;
            cbxNganh.DataSource = nganhQuery;
            cbxNganh.DisplayMember = "TenNganh";
            cbxNganh.ValueMember = "MaNganh";
        }
        private void FormThemLop_Load(object sender, EventArgs e)
        {
            setcbx();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Lop ucheck = db.Lops.SingleOrDefault(u => u.MaLop == txtMalop.Text);
            if (ucheck == null)
            {
                Lop lophocMoi = new Lop();
                lophocMoi.MaNganh = cbxNganh.SelectedValue.ToString();
                lophocMoi.MaLop = txtMalop.Text;
                lophocMoi.TenLop = txtTenlop.Text;
                db.Lops.InsertOnSubmit(lophocMoi);
                db.SubmitChanges();
                clear();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clear()
        {
            cbxKhoa.ResetText();
            txtMalop.Clear();
            txtTenlop.Clear();
            cbxNganh.ResetText();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
