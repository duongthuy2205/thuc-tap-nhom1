namespace AppQL_NhanSu.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [StringLength(5)]
        public string MaNV { get; set; }

        [StringLength(100)]
        public string HoTenNV { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string DanToc { get; set; }

        [StringLength(100)]
        public string QueQuan { get; set; }

        [StringLength(10)]
        public string MaPb { get; set; }

        [StringLength(10)]
        public string MaCV { get; set; }

        [StringLength(50)]
        public string TDHV { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual PhongBan PhongBan { get; set; }
    }
}
