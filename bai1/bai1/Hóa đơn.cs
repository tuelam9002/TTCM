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
    public partial class Hóa_đơn : Form
    {
        public Hóa_đơn()
        {
            InitializeComponent();
        }


        private void btnTPT_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hóa_đơn_Load(object sender, EventArgs e)
        {
            using (SHOPHOATHUTRANGEntities1 quanli = new SHOPHOATHUTRANGEntities1())
            {
                var result = from hd in quanli.HOADON
                             join kh in quanli.KHACHHANG on hd.MAKH equals kh.MAKH
                             join CTHD in quanli.CTHOADON on hd.MAHD equals CTHD.MAHD
                             join nv in quanli.NHANVIEN on hd.MANV equals nv.MANV
                             select new
                             {
                                 kh.MAKH,
                                 kh.TENKH,
                                 kh.DIACHI,
                                 kh.SDT,
                                 hd.NGAYLAPHD,
                                 nv.TENNV,
                                 CTHD.GIABAN,
                                 CTHD.SOLUONGBAN,
                                 hd.TONGTIEN,
                             };
                dgvHD.DataSource = result.ToList();
            }
        }
    }
}
