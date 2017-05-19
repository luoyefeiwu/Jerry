namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.WXBirthdayMarkingSend")]
    public partial class WXBirthdayMarkingSend
    {
        public long WXBirthdayMarkingSendId { get; set; }

        public long WXMarkingSendId { get; set; }

        [Required]
        [StringLength(100)]
        public string OpenId { get; set; }

        public int SendFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string Message { get; set; }

        public virtual WXMarkingSend WXMarkingSend { get; set; }
    }
}
