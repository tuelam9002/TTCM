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
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-4AJU5DJ\SQLEXPRESS;Initial Catalog=SHOPHOATHUTRANG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvNV.DataSource = table;
        }
        public Nhân_viên()
        {
            InitializeComponent();
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
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNV.CurrentRow.Index;
            txtMNV.Text = dgvNV.Rows[i].Cells[0].Value.ToString();
           
            txtTNV.Text = dgvNV.Rows[i].Cells[1].Value.ToString();
            
            txtDCNV.Text = dgvNV.Rows[i].Cells[3].Value.ToString();
            
            txtSDTNV.Text = dgvNV.Rows[i].Cells[5].Value.ToString();
            //dtpkSNNV.Text = dgvNV.Rows[i].Cells[4].Value.ToString();
            cbGTNV.Text=dgvNV.Rows[i].Cells[6].Value.ToString();
            txtSGL.Text = dgvNV.Rows[i].Cells[2].Value.ToString();
            txtLuong.Text = dgvNV.Rows[i].Cells[4].Value.ToString();  
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NHANVIEN values('" + txtMNV.Text + "',N'" + txtTNV.Text + "','" + txtDCNV.Text + "','" + txtSDTNV.Text + "',N'" + cbGTNV.Text + "',N'" + txtSGL.Text + "','" + txtLuong.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                SqlConnection cns = new SqlConnection(str);
                cns.Open();
                string a="delete from NHANVIEN where MANV = '" + txtMNV.Text + "'";
                SqlCommand cmd = new SqlCommand(a, cns);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadData();
                cns.Close();
            }
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            txtMNV.Text = "";
            txtTNV.Text = "";
            txtDCNV.Text = "";
            txtSDTNV.Text = "";
            txtSGL.Text = "";
            txtLuong.Text = "";
            cbGTNV.Text = "";
            dtpkSNNV.Text = "1/1/1900";
        }
    }
}
