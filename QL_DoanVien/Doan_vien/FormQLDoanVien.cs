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
    public partial class FormQuanLyDoanVien : Form
    {
        QLDVDataContext db = new QLDVDataContext();
        public FormQuanLyDoanVien()
        {
            InitializeComponent();
        }

        private void btnQuanLyDoanVien_Click(object sender, EventArgs e)
        {

        }

        private void FormQuanLyDoanVien_Load(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            if (lblVaiTro.Text != "Admin")
            {                             
                btnChuyenSH.Visible = false;
                btnDoanPhi.Visible = false;
                btnThem.Visible = false;
                Column13.Visible = false;
                Column14.Visible = false;
            }
            btnQuanLyDoanVien.BackColor = Color.DodgerBlue;
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            dataGridView1.Rows.Clear();

            var doanVienQuery = from dv in db.Students
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
            foreach(var item in doanVienQuery)
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
                if(item.SoDoan == true)
                {
                    dongmoi.Cells[8].Value = "Đã Nộp";
                }
                else
                {
                    dongmoi.Cells[8].Value = "Chưa Nộp";
                }
                if (item.SinhHoat == true)
                {
                    dongmoi.Cells[9].Value = "Đã Chuyển";
                }
                else
                {
                    dongmoi.Cells[9].Value = "Chưa Chuyển";
                }
                
                dongmoi.Cells[10].Value = item.TenLop;
                dongmoi.Cells[11].Value = item.TenKH;
                dongmoi.Cells[12].Value = "Sửa";
                dongmoi.Cells[13].Value = "Xóa";
                dataGridView1.Rows.Add(dongmoi);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThem ft = new FormThem();
            ft.ShowDialog();

        }

        private void FormQuanLyDoanVien_Activated(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void btnDoanPhi_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormDoanPhi fdp = new FormDoanPhi();
            fdp.Tag = un;
            fdp.Show();
            this.Close();
        }

        private void btnChuyenSH_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormChuyenSH fcsh = new FormChuyenSH();
            fcsh.Tag = un;
            fcsh.Show();
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormTimKiem ftk = new FormTimKiem();
            ftk.Tag = un;
            ftk.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDV = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Student dvXoaSua = db.Students.SingleOrDefault(sp => sp.MaSV == maDV);
            if(e.ColumnIndex == 12)
            {
                FormSuaThongTin fs = new FormSuaThongTin();
                fs.Tag = dvXoaSua;
                fs.ShowDialog();
            }
            if (e.ColumnIndex == 13)
            {
                DialogResult re = MessageBox.Show("Bạn có muốn xóa", "Xác Nhận", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {       
                        db.Students.DeleteOnSubmit(dvXoaSua);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa Thành Công !!", "Thông Báo", MessageBoxButtons.OK);
                        HienThiDanhSach();

                }
                
            }
            
        }

        private void pbtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
