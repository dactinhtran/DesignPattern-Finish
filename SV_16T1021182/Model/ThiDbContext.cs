using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV_16T1021182.Model
{
    public class ThiDbContext : DbContext
    {
        public ThiDbContext() : base("Data Source =.; Initial Catalog = ThiDesignPattern; User ID = sa; Password=123")
        {
        }

        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
    }
}
