using SV_16T1021182.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_16T1021182
{
    public interface ISanPham_16T1021182
    {
        List<SanPham> GetSanPhamList(string maTheLoai);
        void SaveSanPhamList(List<SanPham> listSanPham);
    }
}
