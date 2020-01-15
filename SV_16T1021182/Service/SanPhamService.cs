using SV_16T1021182.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;


namespace SV_16T1021182.Service
{
    public class SanPhamService
    {
        //get from file
        public static List<SanPham> GetAllFromFile(string maTheLoai)
        {
            string pathDataFile = @"D:\HOCTAP\.NET form\SV_16T1021182\SV_16T1021182\Data\sanpham.txt";
            if (File.Exists(pathDataFile))
            {
                ////Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);
                List<SanPham> listSanPham = new List<SanPham>();
                foreach (var lines in listLines)
                {
                    var rs = lines.Split(new char[] { '#' });
                    SanPham sanpham = new SanPham
                    {
                        MaSanPham = rs[0],
                        TenSanPham = rs[1],
                        DonViTinh = rs[2],
                        GiaBan = rs[3],
                        MaTheLoai = rs[4]
                    };
                    if(sanpham.MaTheLoai == maTheLoai)
                     listSanPham.Add(sanpham);
                }
                return listSanPham;
            }
            else return null;
        }

        //get from db
        public static List<SanPham> GetSanPhamListFromDb(string maTheLoai)
        {
            return new ThiDbContext().SanPhams.Where(x=>x.MaTheLoai == maTheLoai).ToList();
        }


        //save to db
        public static void SaveListSanPhamToDb(List<SanPham> listSanPham)
        {
            ThiDbContext context = new ThiDbContext();
            context.SanPhams.RemoveRange(context.SanPhams);
            foreach(var item in listSanPham)
            {
                context.SanPhams.Add(item);
            }
            context.SaveChanges();
        }


        //save to file
        public static void SaveListSanPhamToFile(List<SanPham> sanPhams, string pathContactFile)
        {
            List<string> temp = new List<string>();
            foreach (var item in sanPhams)
            {
                //Tao moi
                string newSanPham = item.MaSanPham + "#" + item.TenSanPham + "#" + item.MaTheLoai;
                //File.AppendAllText(pathContactFile, Environment.NewLine+ newContact );
                temp.Add(newSanPham);
            }
            var lines = temp as IEnumerable<string>;
            File.WriteAllLines(pathContactFile, lines);
        }
    }
}
