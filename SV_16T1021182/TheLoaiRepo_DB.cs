using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SV_16T1021182.Model;
using SV_16T1021182.Service;

namespace SV_16T1021182
{
    public class TheLoaiRepo_DB : ITheLoai_16T1021182
    {
        public List<TheLoai> GetTheLoaiCoSanPhamList()
        {
            return TheLoaiService.GetTheLoaiCoSanPham();
        }

        public List<TheLoai> GetTheLoaiList()
        {
            return TheLoaiService.GetListSanPham();
        }
    }
}
