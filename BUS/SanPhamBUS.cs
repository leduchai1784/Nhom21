using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAO sanPhamDAO;

        public SanPhamBUS()
        {
            sanPhamDAO = new SanPhamDAO();
        }

        public List<SanPhamDTO> GetSanPhamData()
        {
            return sanPhamDAO.GetSanPhamData();
        }
    }
}
