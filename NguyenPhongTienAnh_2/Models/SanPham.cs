using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenPhongTienAnh_2.Models
{
    public class SanPham
    {
        [key]
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int MaNhaCungCap { get; set; }
    }
}