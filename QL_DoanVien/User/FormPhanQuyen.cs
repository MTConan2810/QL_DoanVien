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
    public partial class FormPhanQuyen : Form
    {
        public FormPhanQuyen()
        {
            InitializeComponent();
        }
        QLDVDataContext db = new QLDVDataContext();
        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            PhanQuyen_Click(sender, e);
            User un = (User)this.Tag;
            lblTen.Text = un.Name;
            lblVaiTro.Text = un.Role.TenRole;
            HienThi();
        }

        private void QLTK_Click(object sender, EventArgs e)
        {
            QLTK.BackColor = Color.RoyalBlue;
            TTTK.BackColor = Color.DodgerBlue;
            PhanQuyen.BackColor = Color.DodgerBlue;
            User un = (User)this.Tag;
            FormUser fu = new FormUser();
            fu.Tag = un;
            fu.Show();
            this.Hide();
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
        private void HienThi()
        {
            dataGridViewVT.Rows.Clear();
            dataGridViewVT.AllowUserToAddRows = true;
            //hien thi cho data role
            var vaitro = from vt in db.Roles
                         select new
                         {
                             vt.MaRole,
                             vt.TenRole
                         };
                         

            foreach(var item in vaitro)
            {
                DataGridViewRow dongmoi = (DataGridViewRow)dataGridViewVT.Rows[0].Clone();
                dongmoi.Cells[0].Value = item.MaRole;
                dongmoi.Cells[1].Value = item.TenRole;
                //dongmoi.Cells[2].Value = "Xoá";
                dataGridViewVT.Rows.Add(dongmoi);
            }
            dataGridViewVT.AllowUserToAddRows = false;
            //hien thi cho các quyền      
            dataGridViewPQ.Rows.Clear();
            dataGridViewPQ.AllowUserToAddRows = true;
            var quyen = from pq in db.Permissions
                        select new
                        {
                            pq.MaPMS,
                            pq.TenPMS
                        };
            foreach(var item in quyen)
            {
                DataGridViewRow rowmoi = (DataGridViewRow)dataGridViewPQ.Rows[0].Clone();
                rowmoi.Cells[0].Value = false;
                rowmoi.Cells[1].Value = item.TenPMS;
                dataGridViewPQ.Rows.Add(rowmoi);
            }
            dataGridViewPQ.AllowUserToAddRows = false;
        }
        private void ResetQuyen()
        {
            dataGridViewPQ.Rows.Clear();
            dataGridViewPQ.AllowUserToAddRows = true;
            var quyen = from pq in db.Permissions
                        select new
                        {
                            pq.MaPMS,
                            pq.TenPMS
                        };
            foreach (var item in quyen)
            {
                DataGridViewRow rowmoi = (DataGridViewRow)dataGridViewPQ.Rows[0].Clone();
                rowmoi.Cells[0].Value = false;
                rowmoi.Cells[1].Value = item.TenPMS;
                dataGridViewPQ.Rows.Add(rowmoi);
            }
            dataGridViewPQ.AllowUserToAddRows = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            ResetQuyen();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Role vtcheck = db.Roles.SingleOrDefault(r => r.MaRole == txtMa.Text);
            if(vtcheck==null)
            {
                Role rnew = new Role();
                rnew.MaRole = txtMa.Text;
                rnew.TenRole = txtTen.Text;
                db.Roles.InsertOnSubmit(rnew);
                db.SubmitChanges();
                foreach (DataGridViewRow row in dataGridViewPQ.Rows)
                {
                    
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        PhanQuyen pq = new PhanQuyen();
                        pq.MaRole = txtMa.Text;
                        string tenpq = row.Cells[1].Value.ToString();
                        Permission a = db.Permissions.SingleOrDefault(p => p.TenPMS == tenpq);
                        pq.MaPMS = a.MaPMS;
                        db.PhanQuyens.InsertOnSubmit(pq);
                    }                                                      
                }

                db.SubmitChanges();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                HienThi();
                
            }
            else
            {
                MessageBox.Show("Vai trò đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Role rn = new Role();
            FormCapNhapQuyen fcnq = new FormCapNhapQuyen();
            fcnq.Tag = rn;
            fcnq.ShowDialog();
        }

        private void FormPhanQuyen_Activated(object sender, EventArgs e)
        {
            HienThi();
            btnClear_Click(sender, e);
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewPQ.Rows.Clear();
            dataGridViewPQ.AllowUserToAddRows = true;
            var quyen = from pq in db.PhanQuyens
                        where pq.MaRole.Equals(txtMa.Text)
                        select new { 
                            pq.MaRole,
                            pq.Permission.TenPMS
                        };
            foreach(var item in quyen)
            {
                //foreach (DataGridViewRow row in dataGridViewPQ.Rows)
                //{
                //    Permission per = db.Permissions.SingleOrDefault(p => p.TenPMS == item.TenPMS);
                //    if(per!=null)
                //    {
                //        row.Cells[0].Value = true;
                //    }    
                //}    
                DataGridViewRow rowmoi = (DataGridViewRow)dataGridViewPQ.Rows[0].Clone();
                rowmoi.Cells[0].Value = true;
                rowmoi.Cells[1].Value = item.TenPMS;
                dataGridViewPQ.Rows.Add(rowmoi);
            } 
            dataGridViewPQ.AllowUserToAddRows = false;


        }


        private void dataGridViewVT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dataGridViewVT.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dataGridViewVT.Rows[e.RowIndex].Cells[1].Value.ToString();
            ResetQuyen();
        }
    }
}
