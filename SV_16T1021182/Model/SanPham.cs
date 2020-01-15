using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_16T1021182.Model
{
    public class SanPham
    {
        [Key]
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { set; get; }
        public string GiaBan { get; set; }
        public string MaTheLoai { get; set; }
        public TheLoai TheLoai { get; set; }
    }
}
