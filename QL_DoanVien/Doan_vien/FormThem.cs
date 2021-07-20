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
    public partial class FormThem : Form
    {
        QLDVDataContext db = new QLDVDataContext();
        public FormThem()
        {
            InitializeComponent();
            setcbxLop();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Student scheck = db.Students.SingleOrDefault(s => s.MaSV == txtMaSV.Text);
            if(scheck==null)
            {
                Student dvMoi = new Student();

                dvMoi.MaSV = txtMaSV.Text;
                dvMoi.HoTen = txtHoTen.Text;
                dvMoi.DienThoai = txtSDT.Text;
                dvMoi.NgaySinh = pickNgaySinh.Value;
                dvMoi.NgayVaoDoan = pickNgayVaoDoan.Value;
                dvMoi.GioiTinh = cbGioiTinh.Text;
                dvMoi.ChucVu = cbChucVu.Text;
                if (cbSoDoan.Text == "Đã Nộp")
                {
                    dvMoi.SoDoan = true;
                }
                else
                {
                    dvMoi.SoDoan = false;
                }
                if (cbSinhHoat.Text == "Đã Chuyển")
                {
                    dvMoi.SinhHoat = true;
                }
                else
                {
                    dvMoi.SinhHoat = false;
                }
                dvMoi.MaKH = cbKhoaHoc.SelectedValue.ToString();
                dvMoi.MaLop = cbLopHoc.SelectedValue.ToString();
                dvMoi.MaXa = cbXaPhuong.SelectedValue.ToString();
                dvMoi.DiaChi = cbTinh.Text;
                if(DateTime.Now.Year - dvMoi.NgaySinh.Value.Year >= 18)
                {
                    db.Students.InsertOnSubmit(dvMoi);
                    db.SubmitChanges();
                    MessageBox.Show("đã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đoàn viên phải lớn hơn bằng 18 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Đoàn viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            
        }

        private void cbTinh_DropDown(object sender, EventArgs e)
        {
            var tinhQuery = from tinh in db.Tinhs
                            select tinh;
            cbTinh.DataSource = tinhQuery;
            cbTinh.DisplayMember = "TenTinh";
            cbTinh.ValueMember = "MaTinh";
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

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&char.IsDigit(e.KeyChar))
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
    }
}
