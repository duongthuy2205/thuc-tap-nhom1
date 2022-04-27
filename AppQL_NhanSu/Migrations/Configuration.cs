namespace AppQL_NhanSu.Migrations
{
    using AppQL_NhanSu.entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppQL_NhanSu.entity.Model_NhanSu>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppQL_NhanSu.entity.Model_NhanSu context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var chucvus = new List<CHUCVU>
            {
                new CHUCVU{MaCV="NV",TenCV="Nhân viên"},
                new CHUCVU{MaCV="TN",TenCV="Trưởng nhóm"},
                new CHUCVU{MaCV="QL",TenCV="Quản lý"},
                new CHUCVU{MaCV="TPNS",TenCV="Trưởng phòng nhân sự"},
                new CHUCVU{MaCV="TPTC",TenCV="Trưởng phòng tài chính"},
                new CHUCVU{MaCV="TPKD",TenCV="Trưởng phòng kinh doanh"},
                new CHUCVU{MaCV="TK",TenCV="Thư ký"},
                new CHUCVU{MaCV="DGDH",TenCV="Giám đốc điều hành"}
            };
            chucvus.ForEach(s => context.CHUCVUs.Add(s));
            context.SaveChanges();
            var luongs = new List<LUONG>
            {
                new LUONG{LuongCB=1490000, HSLuong=4.56, HSPC=0.8, MaCV="NV"},
                new LUONG{LuongCB=1490000, HSLuong=5.56, HSPC=0.85, MaCV="TN"},
                new LUONG{LuongCB=1490000, HSLuong=6.56, HSPC=0.88, MaCV="QL"},
                new LUONG{LuongCB=1490000, HSLuong=7.56, HSPC=0.9, MaCV="TPNS"},
                new LUONG{LuongCB=1490000, HSLuong=8.56, HSPC=0.95, MaCV="TPTC"},
                new LUONG{LuongCB=1490000, HSLuong=9.56, HSPC=0.8, MaCV="TPKD"},
                new LUONG{LuongCB=1490000, HSLuong=10.56, HSPC=0.85, MaCV="TK"},
                new LUONG{LuongCB=1490000, HSLuong=11.56, HSPC=0.88, MaCV="DGDH"}
            };
            luongs.ForEach(s => context.LUONGs.Add(s));
            context.SaveChanges();
            var phongbans = new List<PhongBan>
            {
                new PhongBan{MaPb="NS", TenPB="Phòng nhân sự", SDTPB="09863647"},
                new PhongBan{MaPb="TC", TenPB="Phòng tài chính", SDTPB="09863647"},
                new PhongBan{MaPb="KD", TenPB="Phòng kinh doanh", SDTPB="09863647"},
                new PhongBan{MaPb="GD", TenPB="Ban giám đốc", SDTPB="09874657"}
            };
            phongbans.ForEach(s => context.PhongBans.AddOrUpdate(p => p.MaPb, s));
            context.SaveChanges();
            var nhanviens = new List<NhanVien>
            {
                new NhanVien{MaNV="NV001",HoTenNV="Nguyễn Văn A", NgaySinh=DateTime.Parse("1996-04-04"), GioiTinh="nam", MaPb="NS", MaCV="NV", TDHV="Cử nhân" },
                new NhanVien{MaNV="NV002",HoTenNV="Nguyễn Văn C", NgaySinh=DateTime.Parse("1996-10-04"), GioiTinh="nam", MaPb="NS", MaCV="TN", TDHV="Kỹ sư" },
                new NhanVien{MaNV="NV003",HoTenNV="Nguyễn Văn D", NgaySinh=DateTime.Parse("1996-11-15"), GioiTinh="nam", MaPb="NS", MaCV="NV", TDHV="cử nhân"},
                new NhanVien{MaNV="NV004",HoTenNV="Nguyễn Văn E", NgaySinh=DateTime.Parse("1996-12-30"), GioiTinh="nam", MaPb="NS", MaCV="QL", TDHV="thạc sỹ" },
                new NhanVien{MaNV="NV005",HoTenNV="Nguyễn Văn B", NgaySinh=DateTime.Parse("1997-04-20"), GioiTinh="nam", MaPb="TC", MaCV="TPNS", TDHV="cử nhân" },
                new NhanVien{MaNV="NV006",HoTenNV="Nguyễn Thị A", NgaySinh=DateTime.Parse("1996-10-04"), GioiTinh="nữ", MaPb="KD", MaCV="TPTC", TDHV="thạc sỹ" },
                new NhanVien{MaNV="NV007",HoTenNV="Nguyễn Thu A", NgaySinh=DateTime.Parse("1996-11-29"), GioiTinh="nữ", MaPb="TC",MaCV="TPKD", TDHV="tiến sỹ" },
                new NhanVien{MaNV="NV008",HoTenNV="Trần Thị A", NgaySinh=DateTime.Parse("1996-11-16"), GioiTinh="nữ", MaPb="GD",MaCV="TK", TDHV="tiến sỹ" }
            };
            nhanviens.ForEach(s => context.NhanViens.AddOrUpdate(p => p.MaNV, s));
            context.SaveChanges();
        }
    }
}
