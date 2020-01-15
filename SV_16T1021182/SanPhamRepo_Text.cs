using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SV_16T1021182.Model;
using SV_16T1021182.Service;

namespace SV_16T1021182
{
    public class SanPhamRepo_Text : ISanPham_16T1021182
    {
        public List<SanPham> GetSanPhamList(string maTheLoai)
        {
            return SanPhamService.GetAllFromFile(maTheLoai);
        }

        public void SaveSanPhamList(List<SanPham> listSanPham)
        {
            throw new NotImplementedException();
        }
    }
}
