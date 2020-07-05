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
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-4AJU5DJ\SQLEXPRESS;Initial Catalog=SHOPHOATHUTRANG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from KHACHHANG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKH.DataSource = table;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void hdhToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

      

        private void bntXoaKH_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            guna2TextBox1.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            guna2TextBox2.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
            guna2TextBox3.Text = dgvKH.Rows[i].Cells[3].Value.ToString();
            guna2TextBox4.Text = dgvKH.Rows[i].Cells[4].Value.ToString();
            guna2TextBox5.Text = dgvKH.Rows[i].Cells[6].Value.ToString();
            dtpkNSKH.Text = dgvKH.Rows[i].Cells[5].Value.ToString();
            guna2ComboBox2.Text = dgvKH.Rows[i].Cells[6].Value.ToString();
        }
    }
}
