namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseSiteSetting")]
    public partial class BaseSiteSetting
    {
        public int BaseSiteSettingId { get; set; }

        public Guid AppId { get; set; }

        [Required]
        [StringLength(100)]
        public string KeyWord { get; set; }

        [Required]
        [StringLength(100)]
        public string KeyValue { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(250)]
        public string Remark { get; set; }
    }
}
