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
    public partial class Form2 : Form
    {
        

        
        public Form2()
        {
            InitializeComponent();
        }
        public bool kiemtra()
        {
            if (txtTKH.Text == "" || txtDCKH.Text == "" || txtSDTKH.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return false;
            }
            else
                return true;
        }
        private void hdhToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOPHOATHUTRANGDataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.sHOPHOATHUTRANGDataSet1.KHACHHANG);
            
        }

      

        private void bntXoaKH_Click(object sender, EventArgs e)
        {
            
        }
        string makh = "";
        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            makh = dgvKH.CurrentRow.Cells[0].Value.ToString();
            txtTKH.Text = dgvKH.CurrentRow.Cells[1].Value.ToString();
            txtDCKH.Text = dgvKH.CurrentRow.Cells[2].Value.ToString();
            txtSDTKH.Text = dgvKH.CurrentRow.Cells[3].Value.ToString();
            dtpkNSKH.Value = Convert.ToDateTime(dgvKH.CurrentRow.Cells[4].Value.ToString());
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà khách hàng không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
                    {
                        quanli.deleteKH(makh);
                        MessageBox.Show("đã xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                        Form2_Load(sender, e);
                    }
                }
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntTemKH_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                quanli.insertKhachHang(txtTKH.Text, txtDCKH.Text, txtSDTKH.Text, dtpkNSKH.Value);
                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                Form2_Load(sender, e);
            }
        }

        private void bntSuaKH_Click(object sender, EventArgs e)
        {
            if (makh == "")
            {
                MessageBox.Show("Hãy chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                KHACHHANG kh = quanli.KHACHHANG.FirstOrDefault(p => p.MAKH == makh);
                kh.TENKH = txtTKH.Text;
                kh.DIACHI = txtDCKH.Text;
                kh.SDT = txtSDTKH.Text;
                kh.NGAYSINH = dtpkNSKH.Value;
                quanli.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Form2_Load(sender, e);
            }
        }
        //bắt lỗi không cho nhập chữ vào số điện thoại

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTKKH_Click(object sender, EventArgs e)
        {
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                dgvKH.DataSource = quanli.KHACHHANG.Where(p => p.MAKH.Contains(txtTKKH.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
    }
}
