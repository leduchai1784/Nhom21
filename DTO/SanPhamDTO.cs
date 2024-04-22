using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MASP { get; set; }
        public string TENSP { get; set; }
        public int GIA { get; set; }
        public byte[] HINHSP { get; set; }

    }
   
}
