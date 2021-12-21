namespace LTQL_1721050483.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCap",
                c => new
                    {
                        Manhacungcap = c.Int(nullable: false, identity: true),
                        Tennhacungcap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Manhacungcap);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 20),
                        TenSanPham = c.String(maxLength: 50),
                        Manhacungcap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCap", t => t.Manhacungcap, cascadeDelete: true)
                .Index(t => t.Manhacungcap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SanPham", "Manhacungcap", "dbo.NhaCungCap");
            DropIndex("dbo.SanPham", new[] { "Manhacungcap" });
            DropTable("dbo.SanPham");
            DropTable("dbo.NhaCungCap");
        }
    }
}
