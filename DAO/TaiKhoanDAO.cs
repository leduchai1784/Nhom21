using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class TaiKhoanDAO
    {
        private DataProvider provider;

        public TaiKhoanDAO()
        {
            provider = new DataProvider();
        }

        private SqlConnection OpenConnection()
        {
            return DataProvider.OpenConnection();
        }

        public bool CheckLogin(string userName, string passWord )
        {
            bool isValid = false;

            using (SqlConnection connection = OpenConnection())
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TEN_TAIKHOAN = @UserName AND MATKHAU = @PassWord";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", passWord);
         

                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    isValid = true;
                }
            }

            return isValid;
        }


        public bool IsLoginAllowed(string userName)
        {
            bool isAllowed = false;

            using (SqlConnection connection = OpenConnection())
            {
                string query = "SELECT CHOPHEP_LOGIN FROM TaiKhoan WHERE TEN_TAIKHOAN = @UserName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isAllowed = Convert.ToBoolean(result);
                }
            }

            return isAllowed;
        }
    }
}
