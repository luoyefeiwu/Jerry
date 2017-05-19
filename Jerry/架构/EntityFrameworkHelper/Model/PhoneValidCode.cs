namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.PhoneValidCode")]
    public partial class PhoneValidCode
    {
        [Key]
        [StringLength(20)]
        public string Phone { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(4)]
        public string Code { get; set; }

        public int Count { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
