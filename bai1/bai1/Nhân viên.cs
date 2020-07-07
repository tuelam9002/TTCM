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
    public partial class Nhân_viên : Form
    {
      
       
        public Nhân_viên()
        {
            InitializeComponent();
        }
        public bool kiemtra()
        {
            if (txtTNV.Text == "" || txtSGL.Text == "" || txtDCNV.Text == "" || txtLuong.Text == "" || txtSDTNV.Text == ""||cbGTNV.Text == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nhân_viên_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sHOPHOATHUTRANGDataSet6.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter2.Fill(this.sHOPHOATHUTRANGDataSet6.NHANVIEN);
            
            
        }

        

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1()) 

            {
                quanli.insertNhanvien(txtTNV.Text, int.Parse(txtSGL.Text), txtDCNV.Text,int.Parse(txtLuong.Text), txtSDTNV.Text, cbGTNV.Text);
                quanli.SaveChanges();
                MessageBox.Show("Thêm!");
                Nhân_viên_Load(sender, e);
            }
            
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                quanli.deleteNV(manv);
                quanli.SaveChanges();
                MessageBox.Show("Da xoa");
                Nhân_viên_Load(sender, e);
            }
            
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
           
            txtTNV.Text = "";
            txtDCNV.Text = "";
            txtSDTNV.Text = "";
            txtSGL.Text = "";
            txtLuong.Text = "";
            cbGTNV.Text = "";
            dtpkSNNV.Text = "1/1/1900";
        }
        string manv = "";
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (manv == "")
            {
                MessageBox.Show("Hãy chọn nhân viên cần sửa!");
                return;
            }
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                NHANVIEN nv = quanli.NHANVIEN.FirstOrDefault(p => p.MANV == manv);
                nv.TENNV = txtTNV.Text;
                nv.DIACHI = txtDCNV.Text;
                nv.GIOITINH = cbGTNV.Text;
                nv.LUONG = int.Parse(txtLuong.Text);
                nv.SOGIOLAM = int.Parse(txtSGL.Text);
                nv.SDT = txtSDTNV.Text;
                quanli.SaveChanges();
                MessageBox.Show("Sua thanh cong!");
                Nhân_viên_Load(sender, e);
               
            }
        }

        private void btnTimkiemNV_Click(object sender, EventArgs e)
        {
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                dgvNV.DataSource = quanli.NHANVIEN.Where(p => p.MANV.Contains(txtTKKNV.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void dgvNV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            manv = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txtTNV.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            txtDCNV.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            txtSDTNV.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            txtSGL.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
            cbGTNV.Text = dgvNV.CurrentRow.Cells[6].Value.ToString();
            txtLuong.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
