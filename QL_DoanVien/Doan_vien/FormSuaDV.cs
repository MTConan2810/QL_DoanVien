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
    public partial class FormSuaDV : Form
    {
        public FormSuaDV()
        {
            InitializeComponent();
            setcbxLop();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void setcbxLop()
        {
            var lophocQuery = from lop in db.Lops
                                  //where lop.MaNganh == cbNganhHoc.SelectedValue.ToString()
                              select lop;
            cbLopHoc.DataSource = lophocQuery;
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "MaLop";

            var xaQuery = from xa in db.Xas
                              //where xa.MaHuyen == cbQuanHuyen.SelectedValue.ToString()
                          select xa;
            cbXaPhuong.DataSource = xaQuery;
            cbXaPhuong.DisplayMember = "TenXa";
            cbXaPhuong.ValueMember = "MaXa";

            var khoaHocQuery = from khoahoc in db.KhoaHocs
                               select khoahoc;
            cbKhoaHoc.DataSource = khoaHocQuery;
            cbKhoaHoc.DisplayMember = "TenKH";
            cbKhoaHoc.ValueMember = "MaKH";
        }
        private void LoadComboTinh()
        {
            var tinhQuery = from tinh in db.Tinhs
                            select tinh;
            cbTinh.DataSource = tinhQuery;
            cbTinh.DisplayMember = "TenTinh";
            cbTinh.ValueMember = "MaTinh";
        }
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
                    pickNgaySinh.Text = a.NgaySinh.ToString();
                    pickNgayVaoDoan.Text = a.NgayVaoDoan.ToString();
                    cbGioiTinh.Text = a.GioiTinh;
                    cbChucVu.Text = a.ChucVu;
                    cbKhoaHoc.Text = a.KhoaHoc.TenKH;
                    if (a.SinhHoat == true)
                    {
                        cbSinhHoat.Text = "Đã Chuyển";
                    }
                    else
                    {
                        cbSinhHoat.Text = "Chưa Chuyển";
                    }
                    if (a.SoDoan == true)
                    {
                        cbSoDoan.Text = "Đã Nộp";
                    }
                    else
                    {
                        cbSoDoan.Text = "Chưa Nộp";
                    }

                    cbTinh.Text = a.Xa.Huyen.Tinh.TenTinh;
                    cbQuanHuyen.Text = a.Xa.Huyen.TenHuyen;
                    cbXaPhuong.Text = a.Xa.TenXa;

                    cbKhoa.Text = a.Lop.NganhHoc.Khoa.TenKhoa;
                    cbNganhHoc.Text = a.Lop.NganhHoc.TenNganh;
                    cbLopHoc.Text = a.Lop.TenLop;
                }
                else
                {
                    MessageBox.Show("Đoàn viên này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Student dvSua = db.Students.SingleOrDefault(dv => dv.MaSV == txtMaSV.Text);
            dvSua.HoTen = txtHoTen.Text;
            dvSua.MaSV = txtMaSV.Text;
            dvSua.DienThoai = txtSDT.Text;
            dvSua.NgaySinh = pickNgaySinh.Value;
            dvSua.NgayVaoDoan = pickNgayVaoDoan.Value;
            dvSua.GioiTinh = cbGioiTinh.Text;
            dvSua.ChucVu = cbChucVu.Text;
            dvSua.DiaChi = cbTinh.Text;
            dvSua.MaKH = cbKhoaHoc.SelectedValue.ToString();
            dvSua.MaLop = cbLopHoc.SelectedValue.ToString();
            if (cbSinhHoat.Text == "Đã Chuyển")
            {
                dvSua.SinhHoat = true;
            }
            else
            {
                dvSua.SinhHoat = false;
            }
            if (cbSoDoan.Text == "Đã Nộp")
            {
                dvSua.SoDoan = true;
            }
            else
            {
                dvSua.SoDoan = false;
            }
            dvSua.MaXa = cbXaPhuong.SelectedValue.ToString();
            if (DateTime.Now.Year - dvSua.NgaySinh.Value.Year >= 18)
            {
                db.SubmitChanges();
                MessageBox.Show("đã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đoàn viên phải lớn hơn bằng 18 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbTinh_DropDown(object sender, EventArgs e)
        {
            LoadComboTinh();
        }

        private void cbQuanHuyen_DropDown(object sender, EventArgs e)
        {
            var huyenQuery = from huyen in db.Huyens
                             where huyen.MaTinh == cbTinh.SelectedValue.ToString()
                             select huyen;
            cbQuanHuyen.DataSource = huyenQuery;
            cbQuanHuyen.DisplayMember = "TenHuyen";
            cbQuanHuyen.ValueMember = "MaHuyen";
        }

        private void cbXaPhuong_DropDown(object sender, EventArgs e)
        {
            var xaQuery = from xa in db.Xas
                          where xa.MaHuyen == cbQuanHuyen.SelectedValue.ToString()
                          select xa;
            cbXaPhuong.DataSource = xaQuery;
            cbXaPhuong.DisplayMember = "TenXa";
            cbXaPhuong.ValueMember = "MaXa";
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Họ tên chỉ được nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbNganhHoc_DropDown(object sender, EventArgs e)
        {
            var nganhQuery = from nganh in db.NganhHocs
                             where nganh.MaKhoa == cbKhoa.SelectedValue.ToString()
                             select nganh;
            cbNganhHoc.DataSource = nganhQuery;
            cbNganhHoc.DisplayMember = "TenNganh";
            cbNganhHoc.ValueMember = "MaNganh";
        }

        private void cbLopHoc_DropDown(object sender, EventArgs e)
        {
            var lophocQuery = from lop in db.Lops
                              where lop.MaNganh == cbNganhHoc.SelectedValue.ToString()
                              select lop;
            cbLopHoc.DataSource = lophocQuery;
            cbLopHoc.DisplayMember = "TenLop";
            cbLopHoc.ValueMember = "MaLop";
        }
    }
}
