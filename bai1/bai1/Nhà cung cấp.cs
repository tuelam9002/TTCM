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
        SqlConnection connection;
        SqlCommand command;
        string str =@"Data Source=DESKTOP-4AJU5DJ\SQLEXPRESS;Initial Catalog = SHOPHOATHUTRANG; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            SqlConnection cns = new SqlConnection(str);
            try
            {
                cns.Open();
                string sql = "select* from NHACUNGCAP";
                SqlDataAdapter dt = new SqlDataAdapter(sql, cns);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dgvNCC.DataSource = tb;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message); 
            }
            //command = connection.CreateCommand();
            //command.CommandText = "select* from NHACUNGCAP";
            //adapter.SelectCommand = command;
            //table.Clear();
            //adapter.Fill(table);
            //dgvNCC.DataSource = table;
        }
        public Nhà_cung_cấp()
        {
            InitializeComponent();
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNCC.CurrentRow.Index;
            txtMNCC.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txtTNCC.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txtDCNCC.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txtSDTNCC.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();          
            txtSLN.Text = dgvNCC.Rows[i].Cells[4].Value.ToString();
            txtGN.Text = dgvNCC.Rows[i].Cells[5].Value.ToString();
            dtpkNNNCC.Text = dgvNCC.Rows[i].Cells[6].Value.ToString();
            txtTT.Text = dgvNCC.Rows[i].Cells[7].Value.ToString();
        }

        private void Nhà_cung_cấp_Load(object sender, EventArgs e)
        {
            //connection = new SqlConnection(str);
            //connection.Open();
            loadData();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (tb == DialogResult.OK)
            {
                SqlConnection cns = new SqlConnection(str);
                cns.Open();
                string a = "delete from NHACUNGCAP where MANCC = '" + txtMNCC.Text + "'";
                SqlCommand cmd = new SqlCommand(a, cns);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                cns.Close();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SqlConnection cns = new SqlConnection(str);

            try
            {
                if (txtMNCC.Text != "" && txtTNCC.Text != "")
                {
                    cns.Open();
                    string sql = "insert into NHACUNGCAP values('" + txtMNCC.Text + "','" + txtTNCC.Text + "','" + txtDCNCC.Text + "','" + 
                        txtSDTNCC.Text + "','" + txtSLN.Text + "',N'" + txtGN.Text + "','" + dtpkNNNCC.Text + "','" + txtTT.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, cns);
                    int kq = (int)cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loadData();
                    }
                    else MessageBox.Show("Thêm thất bại");
                    cns.Close();
                }
                else MessageBox.Show("Chưa nhập đủ thông tin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
