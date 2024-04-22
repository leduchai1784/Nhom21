using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_cuối_kì
{
    public partial class QliStore : Form
    {
        public QliStore()
        {
            InitializeComponent();
        }

        private void QliStore_Load(object sender, EventArgs e)
        {

        }

        private void lbDanhmuc_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cbbTenMon.Items.Clear();
            //switch(cbbDanhMuc.Text)
           // {
            //    case "Nước":
            //        cbbTenMon.Items.Add("Trà sữa");
            //        cbbTenMon.Items.Add("Cafe"); 
            //        break;
            //    case "Đồ ăn":
            //        cbbTenMon.Items.Add("Cơm");
            //        cbbTenMon.Items.Add("Bánh mì");
            //        break;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBan(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBan.Text = button.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
