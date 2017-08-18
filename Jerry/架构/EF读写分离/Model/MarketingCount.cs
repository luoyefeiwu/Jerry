namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingCount")]
    public partial class MarketingCount
    {
        public int id { get; set; }

        public Guid MarketingGuid { get; set; }

        public Guid MarketingClassificationGuid { get; set; }

        public int SendNumber { get; set; }

        public int OrderNumber { get; set; }

        public int CustomerNumber { get; set; }

        public int DownNumber { get; set; }

        [Required]
        [StringLength(500)]
        public string CoverCrowd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Amount { get; set; }

        public virtual MarketingClassification MarketingClassification { get; set; }
    }
}
