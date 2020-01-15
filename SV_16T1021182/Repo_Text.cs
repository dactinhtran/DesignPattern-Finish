using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_16T1021182
{
    public class Repo_Text : IFactory_16T1021182
    {
        public ISanPham_16T1021182 GetSanPhamRepo(string dataType)
        {
            if (dataType.Equals("File"))
                return new SanPhamRepo_Text();
            throw new Exception("Unknow Type");
        }

        public ITheLoai_16T1021182 GetTheLoaiRepo(string dataType)
        {
            if (dataType.Equals("File"))
                return new TheLoaiRepo_Text();
            throw new Exception("Unknow Type");
        }
    }
}
