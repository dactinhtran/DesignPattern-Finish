using SV_16T1021182.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_16T1021182.Service
{
    public class TheLoaiService
    {
        public static List<TheLoai> GetListSanPham()
        {
            return new ThiDbContext().TheLoais.ToList();
        }

        public static List<TheLoai> GetTheLoaiCoSanPham()
        {
            return new ThiDbContext().TheLoais.Where(x => x.SanPhams.Count() > 0).ToList();
        }

        //get from file
        public static List<TheLoai> GetAllFromFile()
        {
            string pathDataFile = @"D:\HOCTAP\.NET form\SV_16T1021182\SV_16T1021182\Data\theloai.txt";
            if (File.Exists(pathDataFile))
            {
                ////Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);
                List<TheLoai> listTheLoai = new List<TheLoai>();
                foreach (var lines in listLines)
                {
                    var rs = lines.Split(new char[] { '#' });
                    TheLoai theloai = new TheLoai
                    {
                        MaTheLoai = rs[0],
                        TenTheLoai = rs[1]
                    };

                    listTheLoai.Add(theloai);
                }
                return listTheLoai;
            }
            else return null;
        }

        //save to file
        public static void SaveListTheLoaiToFile(List<TheLoai> theLoais, string pathContactFile)
        {
            List<string> temp = new List<string>();
            foreach (var item in theLoais)
            {
                //Tao moi
                string newTheLoai = item.MaTheLoai + "#" + item.TenTheLoai;
                //File.AppendAllText(pathContactFile, Environment.NewLine+ newContact );
                temp.Add(newTheLoai);
            }
            var lines = temp as IEnumerable<string>;
            File.WriteAllLines(pathContactFile, lines);
        }
    }
}
