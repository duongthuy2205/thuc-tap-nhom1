namespace AppQL_NhanSu.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LUONG")]
    public partial class LUONG
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? LuongCB { get; set; }

        public double? HSLuong { get; set; }

        public double? HSPC { get; set; }

        [StringLength(10)]
        public string MaCV { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }
    }
}
