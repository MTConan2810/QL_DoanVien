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
    public partial class FormQLLopHoc : Form
    {
        public FormQLLopHoc()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            cbxKhoa.Text = dataGridViewlopHoc.Rows[d].Cells[0].Value.ToString();
            cbxNganh.Text = dataGridViewlopHoc.Rows[d].Cells[1].Value.ToString();
            txtMalop.Text = dataGridViewlopHoc.Rows[d].Cells[2].Value.ToString();
            txtTenlop.Text = dataGridViewlopHoc.Rows[d].Cells[3].Value.ToString();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            if (lblVaiTro.Text != "Admin")
            {
                QLKhoa.Visible = false;
                QLKHoc.Visible = false;
                QLNganh.Visible = false;
                btnThem.Visible = false;
                btnSua.Visible = false;
                BtnXoa.Visible = false;
            }
            QLLop.BackColor = Color.DodgerBlue;
            setcbx();
            hienthi();

        }
        private void hienthi()
        {
            dataGridViewlopHoc.Rows.Clear();
            var lophocquery = from lophoc in db.Lops
                               select new
                               {
                                   lophoc.NganhHoc.Khoa.TenKhoa,
                                   lophoc.NganhHoc.TenNganh,
                                   lophoc.MaLop,
                                   lophoc.TenLop

                               };
            foreach (var item in lophocquery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dataGridViewlopHoc.Rows[0].Clone();
                dongmoi.Cells[0].Value = item.TenKhoa;
                dongmoi.Cells[1].Value = item.TenNganh;
                dongmoi.Cells[2].Value = item.MaLop;
                dongmoi.Cells[3].Value = item.TenLop;
                dataGridViewlopHoc.Rows.Add(dongmoi);
            }
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
                hienthi();
            }
            else
            {
                MessageBox.Show("Lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Lop lophocSua = db.Lops.SingleOrDefault(lop =>lop.MaLop==txtMalop.Text);
            try
            {
                lophocSua.TenLop = txtTenlop.Text;
                db.SubmitChanges();
                hienthi();
                clear();
            }
            catch
            {
                MessageBox.Show("Thông báo","Chỉ được sửa tên",MessageBoxButtons.OK);
            }
            
        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            Lop lophocXoa = db.Lops.SingleOrDefault(lop =>lop.MaLop == txtMalop.Text);
            DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                db.Lops.DeleteOnSubmit(lophocXoa);
                db.SubmitChanges();
                clear();
                hienthi();
            }                      
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            User un = (User)this.Tag;
            FormQLKhoa qlkhoa = new FormQLKhoa();
            qlkhoa.Tag = un;
            qlkhoa.Closed += (s, args) => this.Close();
            qlkhoa.Activate();
            qlkhoa.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            User un = (User)this.Tag;
            FormQLKhoaHoc qlkhoahoc = new FormQLKhoaHoc();
            qlkhoahoc.Tag = un;
            qlkhoahoc.Closed += (s, args) => this.Close();
            qlkhoahoc.Activate();
            qlkhoahoc.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
            User un = (User)this.Tag;
            FormQLNganh back = new FormQLNganh();
            back.Tag = un;
            back.Closed += (s, args) => this.Close();
            back.Activate();
            back.Show();
            this.Hide();
        }

        private void FormQLLopHoc_Activated(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            cbxKhoa.ResetText();
            txtMalop.Clear();
            txtTenlop.Clear();
            cbxNganh.ResetText();
        }
        private void setcbx()
        {
            var nganhQuery = from ng in db.NganhHocs
                               select ng;
            cbxNganh.DataSource = nganhQuery;
            cbxNganh.DisplayMember = "TenNganh";
            cbxNganh.ValueMember = "MaNganh";
        }

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

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
