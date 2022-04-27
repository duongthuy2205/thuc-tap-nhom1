namespace AppQL_NhanSu.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(40)]
        public string email { get; set; }

        [StringLength(20)]
        public string password { get; set; }
    }
}
