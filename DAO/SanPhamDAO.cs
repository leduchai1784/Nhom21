using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        private DataProvider provider;

        public SanPhamDAO()
        {
            provider = new DataProvider();
        }

        public List<SanPhamDTO> GetSanPhamData()
        {
            List<SanPhamDTO> sanPhamList = new List<SanPhamDTO>();

            string query = "SELECT MASP, TENSP, GIA, HINHSP FROM SANPHAM";
            DataTable data = DataProvider.ExecuteSelectQuery(query, null);

            foreach (DataRow row in data.Rows)
            {
                SanPhamDTO sanPham = new SanPhamDTO();
                sanPham.MASP = row["MASP"].ToString();
                sanPham.TENSP = row["TENSP"].ToString();
                sanPham.GIA = Convert.ToInt32(row["GIA"]);
                sanPham.HINHSP = row["HINHSP"] as byte[];
                sanPhamList.Add(sanPham);
            }

            return sanPhamList;
        }
    }
}
