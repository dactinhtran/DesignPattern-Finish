using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_16T1021182
{
    public interface IFactory_16T1021182
    {
        ITheLoai_16T1021182 GetTheLoaiRepo(string dataType);
        ISanPham_16T1021182 GetSanPhamRepo(string dataType);
    }
}
