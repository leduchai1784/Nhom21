using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    //public class DataProvider
    //{
    //    private static SqlDataAdapter adapter = new SqlDataAdapter();
    //    private static SqlConnection con = new SqlConnection("Data Source = DESKTOP - F5QGU8S\\SQLEXPRESS;Initial Catalog = QLYQUANCAFE; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
    //   // Data Source = DESKTOP - F5QGU8S\SQLEXPRESS;Initial Catalog = QLYQUANCAFE; Integrated Security = True; Encrypt=True;Trust Server Certificate=True

    //    private static SqlConnection OpenConnection()
    //    {
    //        if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
    //        {
    //            con.Open();
    //        }
    //        return con;
    //    }

    public class DataProvider
    {
        private static string connectionString = "Data Source=LAPTOP-NFMFCBFJ;Initial Catalog=QLYQUANCAFE;Integrated Security=True"; // Thay thế bằng chuỗi kết nối của bạn

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        /// <summary>
        /// Phương thức ExecuteSelectQuery() giúp thực thi câu truy vấn SELECT
        /// </summary>
        /// <param name="query">Câu truy vấn, có thể kèm theo tham số (string)</param>
        /// <param name="parameters">Danh sách tham số (SqlParatemer[])</param>
        /// <returns>Bảng kết quả truy vấn (DataTable)</returns>
        public static DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters)
        {
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(result);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
            //SqlCommand cmd = new SqlCommand();
            //DataTable result = new DataTable();
            //try
            //{
            //    cmd.Connection = OpenConnection();
            //    cmd.CommandText = query;
            //    cmd.Parameters.AddRange(parameters);
            //    adapter.SelectCommand = cmd;
            //    adapter.Fill(result);
            //    con.Close();
            //}
            //catch (SqlException e)
            //{
            //    return null;
            //}
            //return result;
        }

        /// <summary>
        /// Phương thức ExecuteNonQuery() giúp thực thi câu truy vấn INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="query">Câu truy vấn, có thể kèm theo tham số (string)</param>
        /// <param name="parameters">Danh sách tham số (SqlParatemer[])</param>
        /// <returns>Số dòng bị ảnh hưởng bởi câu truy vấn này (int)</returns>
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return rowsAffected;
        }
        //SqlCommand cmd = new SqlCommand();
        //int rowsAffected;
        //try
        //{
        //    cmd.Connection = OpenConnection();
        //    cmd.CommandText = query;
        //    cmd.Parameters.AddRange(parameters);
        //    rowsAffected = cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        //catch (SqlException e)
        //{
        //    return 0;
        //}
        //return rowsAffected;
    }
    
}
