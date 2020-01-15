namespace SV_16T1021182.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add1st : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 128),
                        TenSanPham = c.String(),
                        MaTheLoai = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.TheLoais", t => t.MaTheLoai)
                .Index(t => t.MaTheLoai);
            
            CreateTable(
                "dbo.TheLoais",
                c => new
                    {
                        MaTheLoai = c.String(nullable: false, maxLength: 128),
                        TenTheLoai = c.String(),
                    })
                .PrimaryKey(t => t.MaTheLoai);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SanPhams", "MaTheLoai", "dbo.TheLoais");
            DropIndex("dbo.SanPhams", new[] { "MaTheLoai" });
            DropTable("dbo.TheLoais");
            DropTable("dbo.SanPhams");
        }
    }
}
