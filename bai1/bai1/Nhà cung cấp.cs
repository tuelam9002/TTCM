using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bai1
{
    public partial class Nhà_cung_cấp : Form
    {
        public bool kiemtra()
        {
            if (txtTNCC.Text == "" || txtDCNCC.Text == "" || txtSDTNCC.Text == ""|| txtGN.Text==""||txtSLN.Text==""||dtpkNNNCC.Text==""|| txtTT.Text == "")

            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }


        public Nhà_cung_cấp()
        {
            InitializeComponent();
        }
        string mancc = "";
        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mancc = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txtTNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            txtDCNCC.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            txtSDTNCC.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            txtSLN.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
            txtGN.Text = dgvNCC.CurrentRow.Cells[5].Value.ToString();
            txtTT.Text = dgvNCC.CurrentRow.Cells[7].Value.ToString();
            dtpkNNNCC.Value = Convert.ToDateTime(dgvNCC.CurrentRow.Cells[6].Value.ToString());
            
        }

        private void Nhà_cung_cấp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOPHOATHUTRANGDataSet7.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.sHOPHOATHUTRANGDataSet7.NHACUNGCAP);

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                quanli.deleteNCC(mancc);
                quanli.SaveChanges();
                MessageBox.Show("Da xoa");
                Nhà_cung_cấp_Load(sender, e);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                quanli.insertNHACUNGCAP(txtTNCC.Text, txtDCNCC.Text, txtSDTNCC.Text,int.Parse(txtGN.Text) ,int.Parse(txtSLN.Text), dtpkNNNCC.Value,int.Parse( txtTT.Text));
                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Nhà_cung_cấp_Load(sender, e);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvNCC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            mancc = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txtTNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            txtDCNCC.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            txtSDTNCC.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            txtSLN.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
            txtGN.Text = dgvNCC.CurrentRow.Cells[5].Value.ToString();
            txtTT.Text = dgvNCC.CurrentRow.Cells[7].Value.ToString();
            dtpkNNNCC.Value = Convert.ToDateTime(dgvNCC.CurrentRow.Cells[6].Value.ToString());
            //if (e.ColumnIndex == 7)
            //{
            //    if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            //        {
            //            quanli.deleteNCC(mancc);
            //            MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //            Nhà_cung_cấp_Load(sender, e);
            //        }
            //    }
            //}

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (mancc == "")
            {
                MessageBox.Show("Hãy chọn nhà cung cấp cần sửa!");
                return;
            }
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                NHACUNGCAP ncc = quanli.NHACUNGCAP.FirstOrDefault(p => p.MANCC == mancc);
                ncc.TENNCC = txtTNCC.Text;
                ncc.DIACHI = txtDCNCC.Text;
                ncc.SDT = txtSDTNCC.Text;
                ncc.GIANHAP = int.Parse(txtGN.Text);
                ncc.SOLUONGNHAP = int.Parse(txtSLN.Text);
                ncc.TONGTIEN = int.Parse(txtTT.Text);
                ncc.NGAYNHAP = dtpkNNNCC.Value;
                quanli.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Nhà_cung_cấp_Load(sender, e);
            }
        }
    }
}
