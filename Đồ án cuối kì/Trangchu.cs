using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BUS;
using DTO;


namespace Đồ_án_cuối_kì
{
    public partial class Trangchu : Form
    {
        private bool isEmployee = false;
        public Trangchu()
        {

            InitializeComponent();

        }
        public Trangchu(bool isEmployee)
        {
            InitializeComponent();
            this.isEmployee = isEmployee;
            CheckAdminButton(); // Kiểm tra và cập nhật trạng thái của nút quản lý nhân viên khi khởi tạo form
        }
        private void CheckAdminButton()
        {
            //btnAdmin.Enabled = !isEmployee;
             //quảnLíNhânViênToolStripMenuItem.Enabled = isEmployee;  Coi lại


        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null) {
            currentFormChild.Close();   
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childform);
            pnBody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            login frmlogin = new login();
            frmlogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "Trang Chủ";
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void goimonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void pnBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnsNhanvien_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rjGoimon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QliStore());
            label1.Text = rjGoimon.Text;
        }

        

        private void rjThucdon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sanpham());
            label1.Text = rjThucdon.Text;
        }

        private void rjHoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLHoaDon());
            label1.Text = rjHoadon.Text;
        }

        private void rjNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new nhanvien());
            label1.Text = rjNhanvien.Text;
        }

        private void rjTaikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaiKhoan());
            label1.Text = rjTaikhoan.Text;
        }
    }
}
