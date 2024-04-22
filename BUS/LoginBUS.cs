using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Threading.Tasks;


namespace BUS
{
   public class LoginBUS
    {
        private TaiKhoanDAO DAO;

        public LoginBUS()
        {
            DAO = new TaiKhoanDAO();
        }

        public bool ValidateLogin(string userName, string passWord )
        {
            // Gọi phương thức kiểm tra đăng nhập từ Data Access Layer
            return DAO.CheckLogin(userName, passWord);
        }
        public bool IsLoginAllowed(string userName)
        {
            return DAO.IsLoginAllowed(userName);
        }
    }
}
