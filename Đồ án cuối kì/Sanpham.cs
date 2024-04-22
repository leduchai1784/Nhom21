using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace Đồ_án_cuối_kì
{
    public partial class Sanpham : Form
    {
        private SanPhamBUS sanPhamBUS;
        public Sanpham()
        {
            InitializeComponent();
            dgvSanPham.AutoGenerateColumns = false;
            sanPhamBUS = new SanPhamBUS();


        }
        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name.Equals("colHinhAnh"))
            {
                byte[] imageData = (byte[])e.Value;
                if (imageData != null && imageData.Length > 0)
                {
                    Image image = Image.FromStream(new System.IO.MemoryStream(imageData));
                    e.Value = image;
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sanpham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = sanPhamBUS.GetSanPhamData();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
