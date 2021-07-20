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
    public partial class FormQLKhoaHoc : Form
    {
        public FormQLKhoaHoc()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void hienthi()
        {
            dataGridViewKhoahoc.Rows.Clear();
            var khoahocquery = from khoahoc in db.KhoaHocs
                               select new
                               {
                                   khoahoc.MaKH,
                                   khoahoc.TenKH,
                                   khoahoc.LastCode

                            };
            int i = 0;
            foreach (var item in khoahocquery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dataGridViewKhoahoc.Rows[0].Clone();
                dongmoi.Cells[0].Value = i++;
                dongmoi.Cells[1].Value = item.MaKH;
                dongmoi.Cells[2].Value = item.TenKH;
                dongmoi.Cells[3].Value = item.LastCode;
                dataGridViewKhoahoc.Rows.Add(dongmoi);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            if (lblVaiTro.Text != "Admin")
            {
                QLNganh.Visible = false;
                QLKhoa.Visible = false;
                QLLop.Visible = false;
                btnThem.Visible = false;
                btnSua.Visible = false;
                BtnXoa.Visible = false;
            }
            hienthi();
            QLKHoc.BackColor = Color.DodgerBlue;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
            KhoaHoc kcheck = db.KhoaHocs.SingleOrDefault(u => u.MaKH == txtmaKhoahoc.Text);
            if (kcheck == null)
            {
                KhoaHoc khoahocMoi = new KhoaHoc();
                khoahocMoi.MaKH = txtmaKhoahoc.Text;
                khoahocMoi.TenKH = txttenKhoahoc.Text;
                khoahocMoi.LastCode = DateTime.Now.Year;
                db.KhoaHocs.InsertOnSubmit(khoahocMoi);
                db.SubmitChanges();
                hienthi();
                clear();
            }
            else
            {
                MessageBox.Show("Khoá học đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhoaHoc khoahocSUa = db.KhoaHocs.SingleOrDefault(Khoahoc => Khoahoc.MaKH == txtmaKhoahoc.Text);
            khoahocSUa.TenKH = txttenKhoahoc.Text;

            db.SubmitChanges();
            hienthi();
            clear();
        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            KhoaHoc khoahocXoa = db.KhoaHocs.SingleOrDefault(khoahoc => khoahoc.MaKH == txtmaKhoahoc.Text);
            
            try
            {
                DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.KhoaHocs.DeleteOnSubmit(khoahocXoa);
                    db.SubmitChanges();
                    hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewKhoahoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtmaKhoahoc.Text = dataGridViewKhoahoc.Rows[d].Cells[1].Value.ToString();
            txttenKhoahoc.Text = dataGridViewKhoahoc.Rows[d].Cells[2].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            User un = (User)this.Tag;
            FormQLKhoa qlkhoa = new FormQLKhoa();
            qlkhoa.Closed += (s, args) => this.Close();
            qlkhoa.Tag = un;
            qlkhoa.Activate();
            qlkhoa.Show();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            User un = (User)this.Tag;
            FormQLNganh back = new FormQLNganh();
            back.Closed += (s, args) => this.Close();
            back.Tag = un;
            back.Activate();
            back.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            User un = (User)this.Tag;
            FormQLLopHoc qllophoc = new FormQLLopHoc();
            qllophoc.Closed += (s, args) => this.Close();
            qllophoc.Tag = un;
            qllophoc.Activate();
            qllophoc.Show();
        }
        public void clear()
        {
            txtmaKhoahoc.Clear();
            txttenKhoahoc.Clear();
            txtmaKhoahoc.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void FormQLKhoaHoc_Activated(object sender, EventArgs e)
        {
            hienthi();
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
