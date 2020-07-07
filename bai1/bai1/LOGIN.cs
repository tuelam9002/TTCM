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
using System.Data;

namespace bai1
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection str =new SqlConnection( @"Data Source=DESKTOP-4AJU5DJ\SQLEXPRESS;Initial Catalog=SHOPHOATHUTRANG;Integrated Security=True");
            //try
            //{
            //    str.Open();
            //    string tk = txtTK.Text;
            //    string Pass = txtPass.Text;
            //    string SQL = "select *from TAIKHOAN where TENTK='"+tk+"'and PASS='"+Pass+"'";
            //    SqlCommand com = new SqlCommand(SQL, str);
            //    SqlDataReader a = com.ExecuteReader();
            //    if (a.Read() == true)
            //    {
            //        MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //        Form1 f = new Form1();
            //        this.Hide();
            //        f.ShowDialog();
            //        this.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Lỗi kết nối");
            //}
            if(txtTK.Text=="TUỆ LÂM" && txtPass.Text == "00000")
            
            {
               Form1 f = new Form1();
                this.Hide();
                this.Show();
                f.ShowDialog();
               
            }
            else if(txtPass.Text=="" && txtTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

                    
            }

            else {
                MessageBox.Show("BẠN NHẬP SAI TK HOẶC MK", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
