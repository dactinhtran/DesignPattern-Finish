namespace SV_16T1021182.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add2nd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SanPhams", "DonViTinh", c => c.String());
            AddColumn("dbo.SanPhams", "GiaBan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SanPhams", "GiaBan");
            DropColumn("dbo.SanPhams", "DonViTinh");
        }
    }
}
