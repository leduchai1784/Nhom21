using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Đồ_án_cuối_kì
{
    public partial class login : Form
    {
        private LoginBUS BUS;
        public login()
        {
            InitializeComponent();
                BUS = new LoginBUS();
            txtPassword.PasswordChar = '*';

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPassword.Text;

            bool isValidLogin = BUS.ValidateLogin(userName, passWord);
            if (isValidLogin)
            {
                bool isAllowed = BUS.IsLoginAllowed(userName);
                if (isAllowed)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Trangchu trangchu = new Trangchu(isAllowed);
                    trangchu.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản của bạn LA NV!");
                    Trangchu trangchu = new Trangchu(isAllowed);
                    trangchu.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }


        }
    

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            button1.BackColor = Color.FromArgb(100, 0, 0, 0);
            txtPassword.Clear();
            txtUser.Clear();
        }

        private void chkhienmk_CheckedChanged(object sender, EventArgs e)
        {
            //   txtPassword.UseSystemPasswordChar = !chkhienmk.Checked;
            if (txtPassword.PasswordChar == '\0') //null 12345
            {
                txtPassword.PasswordChar = '*'; // *****
                txtPassword.Text = txtPassword.Text;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = txtPassword.Text;
            }
        }
    }
}
