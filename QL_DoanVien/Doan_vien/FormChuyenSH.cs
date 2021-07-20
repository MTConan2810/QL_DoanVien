using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DoanVien
{
    public partial class FormChuyenSH : Form
    {
        QLDVDataContext db = new QLDVDataContext();
        public FormChuyenSH()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormTimKiem ftk = new FormTimKiem();
            ftk.Tag = un;
            ftk.Show();
            this.Close();
        }

        private void btnQuanLyDoanVien_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormQuanLyDoanVien fql = new FormQuanLyDoanVien();
            fql.Tag = un;
            fql.Show();
            this.Close();
        }

        private void btnDoanPhi_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormDoanPhi fdp = new FormDoanPhi();
            fdp.Tag = un;
            fdp.Show();
            this.Close();
        }

        private void pbtnBack_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            if (lblVaiTro.Text != "Admin")
            {
                FormMain1 fm1 = new FormMain1();
                fm1.Tag = un;
                fm1.Show();
                this.Hide();
            }
            else
            {
                FormMain fm = new FormMain();
                fm.Tag = un;
                fm.Show();
                fm.Activate();
                this.Hide();
            }
        }

        private void cbKhoa_DropDown(object sender, EventArgs e)
        {
            var khoaQuery = from khoa in db.Khoas
                            select khoa;
            cbKhoa.DataSource = khoaQuery;
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void cbNganhHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var doanVienQuery = from dv in db.Students
                                where dv.Lop.NganhHoc.MaNganh == cbNganhHoc.SelectedValue.ToString()
                                select new
                                {
                                    dv.MaSV,
                                    dv.HoTen,
                                    dv.GioiTinh,
                                    dv.NgaySinh,
                                    dv.NgayVaoDoan,
                                    dv.DienThoai,
                                    dv.DiaChi,
                                    dv.ChucVu,
                                    dv.SoDoan,
                                    dv.SinhHoat,
                                    dv.Lop.TenLop,
                                    dv.KhoaHoc.TenKH
                                };

            foreach (var item in doanVienQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dongmoi.Cells[0].Value = item.MaSV;
                dongmoi.Cells[1].Value = item.HoTen;
                dongmoi.Cells[2].Value = item.GioiTinh;
                dongmoi.Cells[3].Value = item.NgaySinh;
                dongmoi.Cells[4].Value = item.NgayVaoDoan;
                dongmoi.Cells[5].Value = item.DienThoai;
                dongmoi.Cells[6].Value = item.DiaChi;
                dongmoi.Cells[7].Value = item.ChucVu;
                dongmoi.Cells[8].Value = item.SoDoan;
                dongmoi.Cells[9].Value = item.SinhHoat;
                dongmoi.Cells[10].Value = item.TenLop;
                dongmoi.Cells[11].Value = item.TenKH;
                // dongmoi.Cells[11].Value = item.MaSV;
                dataGridView1.Rows.Add(dongmoi);
            }
        }

        private void cbKhoaHoc_DropDown(object sender, EventArgs e)
        {
            var khQuery = from kh in db.KhoaHocs

                          select kh;
            cbKhoaHoc.DataSource = khQuery;
            cbKhoaHoc.DisplayMember = "TenKH";
            cbKhoaHoc.ValueMember = "MaKH";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var doanVienQuery = from dv in db.Students
                                where dv.HoTen.Contains(txtTimTen.Text)
                                select new
                                {
                                    dv.MaSV,
                                    dv.HoTen,
                                    dv.GioiTinh,
                                    dv.NgaySinh,
                                    dv.NgayVaoDoan,
                                    dv.DienThoai,
                                    dv.DiaChi,
                                    dv.ChucVu,
                                    dv.SoDoan,
                                    dv.SinhHoat,
                                    dv.Lop.TenLop,
                                    dv.KhoaHoc.TenKH
                                };
            if (doanVienQuery.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy đoàn viên có tên " + txtTimTen.Text, "Thông Báo", MessageBoxButtons.OK);
            }
            foreach (var item in doanVienQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dongmoi.Cells[0].Value = item.MaSV;
                dongmoi.Cells[1].Value = item.HoTen;
                dongmoi.Cells[2].Value = item.GioiTinh;
                dongmoi.Cells[3].Value = item.NgaySinh;
                dongmoi.Cells[4].Value = item.NgayVaoDoan;
                dongmoi.Cells[5].Value = item.DienThoai;
                dongmoi.Cells[6].Value = item.DiaChi;
                dongmoi.Cells[7].Value = item.ChucVu;
                dongmoi.Cells[8].Value = item.SoDoan;
                dongmoi.Cells[9].Value = item.SinhHoat;
                dongmoi.Cells[10].Value = item.TenLop;
                dongmoi.Cells[11].Value = item.TenKH;
                // dongmoi.Cells[11].Value = item.MaSV;
                dataGridView1.Rows.Add(dongmoi);
            }
        }

        private void cbKhoaHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var doanVienQuery = from dv in db.Students
                                where dv.KhoaHoc.MaKH == cbKhoaHoc.SelectedValue.ToString()
                                select new
                                {
                                    dv.MaSV,
                                    dv.HoTen,
                                    dv.GioiTinh,
                                    dv.NgaySinh,
                                    dv.NgayVaoDoan,
                                    dv.DienThoai,
                                    dv.DiaChi,
                                    dv.ChucVu,
                                    dv.SoDoan,
                                    dv.SinhHoat,
                                    dv.Lop.TenLop,
                                    dv.KhoaHoc.TenKH
                                };
            
            foreach (var item in doanVienQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dongmoi.Cells[0].Value = item.MaSV;
                dongmoi.Cells[1].Value = item.HoTen;
                dongmoi.Cells[2].Value = item.GioiTinh;
                dongmoi.Cells[3].Value = item.NgaySinh;
                dongmoi.Cells[4].Value = item.NgayVaoDoan;
                dongmoi.Cells[5].Value = item.DienThoai;
                dongmoi.Cells[6].Value = item.DiaChi;
                dongmoi.Cells[7].Value = item.ChucVu;
                dongmoi.Cells[8].Value = item.SoDoan;
                dongmoi.Cells[9].Value = item.SinhHoat;
                dongmoi.Cells[10].Value = item.TenLop;
                dongmoi.Cells[11].Value = item.TenKH;
                // dongmoi.Cells[11].Value = item.MaSV;
                dataGridView1.Rows.Add(dongmoi);
            }
        }

        private void cbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var doanVienQuery = from dv in db.Students
                                where dv.Lop.NganhHoc.Khoa.MaKhoa == cbKhoa.SelectedValue.ToString()
                                select new
                                {
                                    dv.MaSV,
                                    dv.HoTen,
                                    dv.GioiTinh,
                                    dv.NgaySinh,
                                    dv.NgayVaoDoan,
                                    dv.DienThoai,
                                    dv.DiaChi,
                                    dv.ChucVu,
                                    dv.SoDoan,
                                    dv.SinhHoat,
                                    dv.Lop.TenLop,
                                    dv.KhoaHoc.TenKH
                                };

            foreach (var item in doanVienQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dongmoi.Cells[0].Value = item.MaSV;
                dongmoi.Cells[1].Value = item.HoTen;
                dongmoi.Cells[2].Value = item.GioiTinh;
                dongmoi.Cells[3].Value = item.NgaySinh;
                dongmoi.Cells[4].Value = item.NgayVaoDoan;
                dongmoi.Cells[5].Value = item.DienThoai;
                dongmoi.Cells[6].Value = item.DiaChi;
                dongmoi.Cells[7].Value = item.ChucVu;
                dongmoi.Cells[8].Value = item.SoDoan;
                dongmoi.Cells[9].Value = item.SinhHoat;
                dongmoi.Cells[10].Value = item.TenLop;
                dongmoi.Cells[11].Value = item.TenKH;
                // dongmoi.Cells[11].Value = item.MaSV;
                dataGridView1.Rows.Add(dongmoi);
            }
        }

        private void cbNganhHoc_DropDown(object sender, EventArgs e)
        {
            var nganhQuery = from nganh in db.NganhHocs
                             where nganh.Khoa.TenKhoa == cbKhoa.Text
                            select nganh;
            cbNganhHoc.DataSource = nganhQuery;
            cbNganhHoc.DisplayMember = "TenNganh";
            cbNganhHoc.ValueMember = "MaNganh";
        }

        private void cbLopHoc_DropDown(object sender, EventArgs e)
        {
            var lopQuery = from lop in db.Lops
                           where lop.MaNganh == cbNganhHoc.SelectedValue.ToString()
                           select lop;
            cbLopHoc.DataSource = lopQuery;
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "MaLop";
        }

        private void cbLopHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var doanVienQuery = from dv in db.Students
                                where dv.Lop.MaLop == cbLopHoc.SelectedValue.ToString()
                                select new
                                {
                                    dv.MaSV,
                                    dv.HoTen,
                                    dv.GioiTinh,
                                    dv.NgaySinh,
                                    dv.NgayVaoDoan,
                                    dv.DienThoai,
                                    dv.DiaChi,
                                    dv.ChucVu,
                                    dv.SoDoan,
                                    dv.SinhHoat,
                                    dv.Lop.TenLop,
                                    dv.KhoaHoc.TenKH
                                };

            foreach (var item in doanVienQuery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dongmoi.Cells[0].Value = item.MaSV;
                dongmoi.Cells[1].Value = item.HoTen;
                dongmoi.Cells[2].Value = item.GioiTinh;
                dongmoi.Cells[3].Value = item.NgaySinh;
                dongmoi.Cells[4].Value = item.NgayVaoDoan;
                dongmoi.Cells[5].Value = item.DienThoai;
                dongmoi.Cells[6].Value = item.DiaChi;
                dongmoi.Cells[7].Value = item.ChucVu;
                dongmoi.Cells[8].Value = item.SoDoan;
                dongmoi.Cells[9].Value = item.SinhHoat;
                dongmoi.Cells[10].Value = item.TenLop;
                dongmoi.Cells[11].Value = item.TenKH;
                // dongmoi.Cells[11].Value = item.MaSV;
                dataGridView1.Rows.Add(dongmoi);
            }
        }

        private void FormChuyenSH_Load(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            if (lblVaiTro.Text != "Admin")
            {
                btnDoanPhi.Visible = false;
                btnQuanLyDoanVien.Visible = false;
                btnTimKiem.Visible = false;
            }
            btnChuyenSH.BackColor = Color.DodgerBlue;
        }

        private void pbtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDV = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Student dvDP = db.Students.SingleOrDefault(sp => sp.MaSV == maDV);
            txtMasv.Text = dvDP.MaSV;
            if (dvDP.SinhHoat == true)
            {
                rbtnDaChuyen.Checked = true;
                rbtnChuaChuyen.Checked = false;
            }
            else
            {
                rbtnChuaChuyen.Checked = true;
                rbtnDaChuyen.Checked = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student dvDP = db.Students.SingleOrDefault(sp => sp.MaSV == txtMasv.Text);
            if (rbtnDaChuyen.Checked == true)
            {
                dvDP.SinhHoat = true;
            }
            else if (rbtnChuaChuyen.Checked == true)
            {
                dvDP.SinhHoat = false;
            }
        }

        private void rbtnChuaChuyen_Click(object sender, EventArgs e)
        {
            rbtnDaChuyen.Checked = false;
        }

        private void rbtnDaChuyen_Click(object sender, EventArgs e)
        {
            rbtnChuaChuyen.Checked = false;
        }
    }
}
