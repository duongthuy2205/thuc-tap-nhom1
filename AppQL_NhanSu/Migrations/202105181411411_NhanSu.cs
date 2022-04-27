namespace AppQL_NhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhanSu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CHUCVU",
                c => new
                    {
                        MaCV = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenCV = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaCV);
            
            CreateTable(
                "dbo.LUONG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LuongCB = c.Int(),
                        HSLuong = c.Double(),
                        HSPC = c.Double(),
                        MaCV = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CHUCVU", t => t.MaCV)
                .Index(t => t.MaCV);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 5, unicode: false),
                        HoTenNV = c.String(maxLength: 100),
                        SoDienThoai = c.String(maxLength: 10, unicode: false),
                        GioiTinh = c.String(maxLength: 3),
                        NgaySinh = c.DateTime(storeType: "date"),
                        DanToc = c.String(maxLength: 50),
                        QueQuan = c.String(maxLength: 100),
                        MaPb = c.String(maxLength: 10, unicode: false),
                        MaCV = c.String(maxLength: 10, unicode: false),
                        TDHV = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.CHUCVU", t => t.MaCV)
                .ForeignKey("dbo.PhongBan", t => t.MaPb)
                .Index(t => t.MaPb)
                .Index(t => t.MaCV);
            
            CreateTable(
                "dbo.PhongBan",
                c => new
                    {
                        MaPb = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenPB = c.String(maxLength: 50),
                        SDTPB = c.String(maxLength: 8, unicode: false),
                        DiaChi = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.MaPb);
            
            CreateTable(
                "dbo.TaiKhoan",
                c => new
                    {
                        email = c.String(nullable: false, maxLength: 40, unicode: false),
                        password = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.email);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanVien", "MaPb", "dbo.PhongBan");
            DropForeignKey("dbo.NhanVien", "MaCV", "dbo.CHUCVU");
            DropForeignKey("dbo.LUONG", "MaCV", "dbo.CHUCVU");
            DropIndex("dbo.NhanVien", new[] { "MaCV" });
            DropIndex("dbo.NhanVien", new[] { "MaPb" });
            DropIndex("dbo.LUONG", new[] { "MaCV" });
            DropTable("dbo.TaiKhoan");
            DropTable("dbo.PhongBan");
            DropTable("dbo.NhanVien");
            DropTable("dbo.LUONG");
            DropTable("dbo.CHUCVU");
        }
    }
}
