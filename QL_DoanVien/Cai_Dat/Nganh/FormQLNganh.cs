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
    public partial class FormQLNganh : Form
    {
        public FormQLNganh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            if (lblVaiTro.Text != "Admin")
            {
                QLKhoa.Visible = false;
                QLKHoc.Visible = false;
                QLLop.Visible = false;
                btnThem.Visible = false;
                btnSua.Visible = false;
                BtnXoa.Visible = false;
            }
            hienthi();
            taoDScombo();
            QLNganh.BackColor = Color.DodgerBlue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            
            txtmaNganh.Text = dataGridViewNganh.Rows[d].Cells[0].Value.ToString();
            txttenNganh.Text = dataGridViewNganh.Rows[d].Cells[1].Value.ToString();
            cbxKhoa.Text = dataGridViewNganh.Rows[d].Cells[2].Value.ToString();
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
        private void hienthi()
        {
            dataGridViewNganh.Rows.Clear();
            var nganhquery = from nganh in db.NganhHocs
                             select new
                             {
                                 nganh.MaNganh,
                                 nganh.TenNganh,
                                 nganh.Khoa.TenKhoa

                             };
            foreach(var item in nganhquery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dataGridViewNganh.Rows[0].Clone();

                dongmoi.Cells[0].Value = item.MaNganh;
                dongmoi.Cells[1].Value = item.TenNganh;
                dongmoi.Cells[2].Value = item.TenKhoa;
                dataGridViewNganh.Rows.Add(dongmoi);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NganhHoc ncheck = db.NganhHocs.SingleOrDefault(u => u.MaNganh == txtmaNganh.Text);
            if(ncheck==null)
            {
                NganhHoc nganhMoi = new NganhHoc();
                nganhMoi.MaNganh = txtmaNganh.Text;
                nganhMoi.TenNganh = txttenNganh.Text;
                nganhMoi.MaKhoa = cbxKhoa.SelectedValue.ToString();
                db.NganhHocs.InsertOnSubmit(nganhMoi);
                db.SubmitChanges();
                hienthi();
            }    
            else
            {
                MessageBox.Show("Ngành đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NganhHoc nganhSua = db.NganhHocs.SingleOrDefault(nganh => nganh.MaNganh == txtmaNganh.Text);
            nganhSua.TenNganh = txttenNganh.Text;
            nganhSua.MaKhoa = cbxKhoa.SelectedValue.ToString();
            db.SubmitChanges();
            hienthi();

        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            try
            {
                NganhHoc nganhXoa = db.NganhHocs.SingleOrDefault(nganh => nganh.MaNganh == txtmaNganh.Text);
                DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.NganhHocs.DeleteOnSubmit(nganhXoa);
                    db.SubmitChanges();
                    btnClear_Click(sender, e);
                    hienthi();
                }    
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            User un = (User)this.Tag;
            FormQLKhoa qlkhoa = new FormQLKhoa();
            qlkhoa.Tag = un;
            qlkhoa.Closed += (s, args) => this.Close();
            qlkhoa.Activate();
            qlkhoa.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            User un = (User)this.Tag;
            FormQLKhoaHoc qlkhoahoc = new FormQLKhoaHoc();
            qlkhoahoc.Tag = un;
            qlkhoahoc.Closed += (s, args) => this.Close();
            qlkhoahoc.Activate();
            qlkhoahoc.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            User un = (User)this.Tag;
            FormQLLopHoc qllophoc = new FormQLLopHoc();
            qllophoc.Tag = un;
            qllophoc.Closed += (s, args) => this.Close();
            qllophoc.Activate();
            qllophoc.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtmaNganh.Clear();
            txttenNganh.Clear();
            cbxKhoa.ResetText();
            txtmaNganh.Focus();
        }

        private void FormQLNganh_Activated(object sender, EventArgs e)
        {
            hienthi();
            btnClear_Click(sender, e);
        }
    }
}
