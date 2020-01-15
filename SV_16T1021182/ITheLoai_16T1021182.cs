using SV_16T1021182.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_16T1021182
{
    public interface ITheLoai_16T1021182
    {
        List<TheLoai> GetTheLoaiList();
        List<TheLoai> GetTheLoaiCoSanPhamList();
    }
}
