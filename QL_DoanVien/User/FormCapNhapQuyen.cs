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
    public partial class FormCapNhapQuyen : Form
    {
        public FormCapNhapQuyen()
        {
            InitializeComponent();
            
        }
        QLDVDataContext db = new QLDVDataContext();

        private void FormCapNhapQuyen_Load(object sender, EventArgs e)
        {
            setCombo();
            HienThi();
            
        }
        private void setCombo()
        {
            var vaitro = from vt in db.Roles
                         where !vt.MaRole.Equals("R1")
                         select vt;
            cbxTenVT.DataSource = vaitro;
            cbxTenVT.DisplayMember = "TenRole";
            cbxTenVT.ValueMember = "MaRole";
        }
        private void HienThi()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var xoaallquyen = from pqx in db.PhanQuyens where pqx.MaRole == cbxTenVT.SelectedValue.ToString() select pqx;
                db.PhanQuyens.DeleteAllOnSubmit(xoaallquyen);
                db.SubmitChanges();
                foreach (DataGridViewRow row in dataGridViewPQ.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        PhanQuyen pq = new PhanQuyen();
                        pq.MaRole = cbxTenVT.SelectedValue.ToString();
                        string tenpq = row.Cells[1].Value.ToString();
                        Permission a = db.Permissions.SingleOrDefault(p => p.TenPMS == tenpq);
                        pq.MaPMS = a.MaPMS;
                        db.PhanQuyens.InsertOnSubmit(pq);
                    }
                    
                    db.SubmitChanges();
                }
                MessageBox.Show("thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thành công, quyền đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }
    }
}
