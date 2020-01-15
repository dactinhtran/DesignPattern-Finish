using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_16T1021182.Model
{
    public class TheLoai
    {
        [Key]
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public List<SanPham> SanPhams { get; set; }
    }
}
