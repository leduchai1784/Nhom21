using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;


    namespace Đồ_án_cuối_kì
{
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }

        private bool modenew;
        private int row;

        private void SetControl(bool edit)
        {
            btnThem.Enabled = !edit;
            btnCapnhat.Enabled = !edit;
            btnXoa.Enabled = !edit;
            btnLuu.Enabled = edit;
            //btnCancel.Enabled = edit;
        }

        private void grbthongtin_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void lbDiachi_Click(object sender, EventArgs e)
        {

        }

        private void lbGioitinh_Click(object sender, EventArgs e)
        {

        }

        private void lbChucvu_Click(object sender, EventArgs e)
        {

        }

        private void chknu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
        //    string query = "select MANV, TENNV, GIOITINH, NGAYSINH, DIACHI, CHUCVU from NhanVien";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    listView1.Items.Clear();

        //    foreach (DataRow row in data.Rows)
        //    {
        //        ListViewItem item = new ListViewItem(row[0].ToString());
        //        for (int i = 1; i < data.Columns.Count; i++)
        //        {
        //            item.SubItems.Add(row[i].ToString());
        //        }
        //        listView1.Items.Add(item);
        //    }

        //    listView1.View = View.Details; // Đặt chế độ View là Detail để hiển thị dạng bảng
        //    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //row = e.ItemIndex;
            //txtMaNv.Text = listView1.Items[row].SubItems[0].Text;
            //txtTen.Text = listView1.Items[row].SubItems[1].Text;
            ////Còn cái ngày sinh nghen (radio button)
            //dtpNgaySinh.Text = listView1.Items[row].SubItems[3].Text;
            //txtDiachi.Text = listView1.Items[row].SubItems[4].Text;
            //cbbChucvu.Text = listView1.Items[row].SubItems[5].Text;
        }
    }
}
