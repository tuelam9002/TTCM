using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private int _img = 1;
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(_img == 1)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa1;
                _img = 2;
            }
            else if(_img == 2)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa2;
                _img = 3;
            }
            else if (_img == 3)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa3;
                _img = 4;
            }
            else if (_img == 4)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa4;
                _img = 5;
            }
            else if (_img == 5)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa5;
                _img = 6;
            }
            else if (_img == 6)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa6;
                _img = 7;
            }
            else if (_img == 7)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa7;
                _img = 8;
            }
            else if (_img == 8)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa8;
                _img = 9;
            }
            else if (_img == 9)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa9;
                _img = 10;
            }
            else if (_img == 10)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa10;
                _img = 11;
            }
            else if (_img == 11)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa11;
                _img = 12;
            }
            else if (_img == 12)
            {
                pcchinh.Image = bai1.Properties.Resources.hoa12;
                _img = 13;
            }
            else 
            {
                pcchinh.Image = bai1.Properties.Resources.hoa1;
                _img = 1;
            }
            


        }

        private void pcchinh_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                
                
        }

        private void jhbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hhhhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchKháchHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhân_viên f = new Nhân_viên();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Quản_lý_HOA f = new Quản_lý_HOA();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhà_cung_cấp f = new Nhà_cung_cấp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            Hóa_đơn f = new Hóa_đơn();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            Tồn_kho f = new Tồn_kho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
