using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenPhongTienAnh_2.Models
{
    [Table("NhaCungCaps")]
    public class NhaCungCap
    {
        [key]
        public int MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }

    }
}