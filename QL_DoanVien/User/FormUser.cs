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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void FormUser_Load(object sender, EventArgs e)
        {
            QLTK_Click(sender, e);
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            HienThi();
            setCombo();

        }
        private void HienThi()
        {
            dataGridView1.Rows.Clear();
            var nguoidung = from us in db.Users 
                            select new {
                us.MaUser,
                us.Username,
                us.Password,
                us.Name,
                us.Khoa.TenKhoa,
                us.Role.TenRole
            };
            foreach(var item in nguoidung)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dongmoi.Cells[0].Value = item.MaUser;
                dongmoi.Cells[1].Value = item.Username;
                dongmoi.Cells[2].Value = item.Password;
                dongmoi.Cells[3].Value = item.Name;
                dongmoi.Cells[4].Value = item.TenKhoa;
                dongmoi.Cells[5].Value = item.TenRole;
                dataGridView1.Rows.Add(dongmoi);
            }    
        }
        
        private void setCombo()
        {
            var vaitro = from vt in db.Roles select vt;
            cbxVaitro.DataSource = vaitro;
            cbxVaitro.DisplayMember = "TenRole";
            cbxVaitro.ValueMember = "MaRole";
            var donvi = from dv in db.Khoas select dv;
            cbxDonVi.DataSource = donvi;
            cbxDonVi.DisplayMember = "TenKhoa";
            cbxDonVi.ValueMember = "MaKhoa";
        }
        
        private void QLTK_Click(object sender, EventArgs e)
        {
            QLTK.BackColor = Color.RoyalBlue;
            TTTK.BackColor = Color.DodgerBlue;
            PhanQuyen.BackColor = Color.DodgerBlue;
        }

        private void TTTK_Click(object sender, EventArgs e)
        {
            QLTK.BackColor = Color.DodgerBlue;
            TTTK.BackColor = Color.RoyalBlue;
            PhanQuyen.BackColor = Color.DodgerBlue;
            User un = (User)this.Tag;
            FormTTUser fttu = new FormTTUser();
            fttu.Tag = un;
            fttu.Show();
            this.Hide();
        }

        private void PhanQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen.BackColor = Color.RoyalBlue;
            QLTK.BackColor = Color.DodgerBlue;
            TTTK.BackColor = Color.DodgerBlue;
            User un = (User)this.Tag;
            FormPhanQuyen fpq = new FormPhanQuyen();
            fpq.Tag = un;
            fpq.Show();
            this.Hide();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            User un = (User)this.Tag;
            FormMain fm = new FormMain();
            fm.Tag = un;
            fm.Show();
            fm.Activate();
            this.Hide();
        }

        private void pbSutdown_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            User ucheck = db.Users.SingleOrDefault(u => u.Username == txtUsername.Text);
            if(ucheck==null)
            {
                User unew = new User();
                unew.MaUser = "U" + (db.Users.ToList().Count() + 1).ToString();
                unew.Username = txtUsername.Text;
                unew.Password = txtPassword.Text;
                unew.Name = txtTen.Text;
                unew.MaKhoa = cbxDonVi.SelectedValue.ToString();
                unew.MaRole = cbxVaitro.SelectedValue.ToString();
                db.Users.InsertOnSubmit(unew);
                db.SubmitChanges();
                HienThi();
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormUser_Activated(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxDonVi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxVaitro.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtTen.Clear();
            txtUsername.Clear();
            cbxDonVi.ResetText();
            cbxVaitro.ResetText();
            txtUsername.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            User uckeck = db.Users.SingleOrDefault(u => u.Username == txtUsername.Text);
            uckeck.Name = txtTen.Text;
            uckeck.Password = txtPassword.Text;
            uckeck.MaKhoa = cbxDonVi.SelectedValue.ToString();
            uckeck.MaRole = cbxVaitro.SelectedValue.ToString();

            db.SubmitChanges();
            HienThi();
            btnClear_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            User uckeck = db.Users.SingleOrDefault(u => u.Username == txtUsername.Text);
            DialogResult rs = MessageBox.Show("bạn có muốn xoá", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                db.Users.DeleteOnSubmit(uckeck);
                db.SubmitChanges();
                HienThi();
                btnClear_Click(sender, e);
            }
        }
    }
}
