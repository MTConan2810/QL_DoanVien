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
    public partial class FormQLKhoa : Form
    {
        public FormQLKhoa()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void hienthi()
        {
            dataGridViewKhoa.Rows.Clear();
            var khoaquery = from khoa in db.Khoas
                             select new
                             {
                                 khoa.MaKhoa,
                                 khoa.TenKhoa

                             };
            foreach (var item in khoaquery)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)
                dataGridViewKhoa.Rows[0].Clone();
                dongmoi.Cells[1].Value = item.MaKhoa;
                dongmoi.Cells[2].Value = item.TenKhoa;
                dataGridViewKhoa.Rows.Add(dongmoi);
            }
        }

        private void dataGridViewKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtmaKhoa.Text = dataGridViewKhoa.Rows[d].Cells[0].Value.ToString();
            txttenKhoa.Text = dataGridViewKhoa.Rows[d].Cells[1].Value.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            if (lblVaiTro.Text != "Admin")
            {
                QLNganh.Visible = false;
                QLKHoc.Visible = false;
                QLLop.Visible = false;
                btnThem.Visible = false;
                btnSua.Visible = false;
                BtnXoa.Visible = false;
            }
            hienthi();
            QLKhoa.BackColor = Color.DodgerBlue;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Khoa kcheck = db.Khoas.SingleOrDefault(u => u.MaKhoa == txtmaKhoa.Text);
            if (kcheck == null)
            {
                Khoa khoaMoi = new Khoa();
                khoaMoi.MaKhoa = txtmaKhoa.Text;
                khoaMoi.TenKhoa = txttenKhoa.Text;
                db.Khoas.InsertOnSubmit(khoaMoi);
                db.SubmitChanges();
                clear();
                hienthi();
            }
            else
            {
                MessageBox.Show("Khoa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Khoa khoaSUa = db.Khoas.SingleOrDefault(Khoa => Khoa.MaKhoa == txtmaKhoa.Text);
            
            khoaSUa.TenKhoa = txttenKhoa.Text;
            
            db.SubmitChanges();
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

        private void Xoá_Click(object sender, EventArgs e)
        {
            Khoa khoaXoa = db.Khoas.SingleOrDefault(khoa => khoa.MaKhoa == txtmaKhoa.Text);
            try
            {
                DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.Khoas.DeleteOnSubmit(khoaXoa);
                    db.SubmitChanges();
                    hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


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
            qllophoc.Closed += (s, args) => this.Close();
            qllophoc.Tag = un;
            qllophoc.Activate();
            qllophoc.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
        }
        public void clear()
        {
            txtmaKhoa.Clear();
            txttenKhoa.Clear();
            txtmaKhoa.Focus();
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
