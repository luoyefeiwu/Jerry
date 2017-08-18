namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.CreditChangeLog")]
    public partial class CreditChangeLog
    {
        public Guid CreditChangeLogId { get; set; }

        public Guid CustomerGuid { get; set; }

        public int SourceType { get; set; }

        [Required]
        [StringLength(50)]
        public string SourceId { get; set; }

        public int OriginalValue { get; set; }

        public int ChangeValue { get; set; }

        [Required]
        public string Desc { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
