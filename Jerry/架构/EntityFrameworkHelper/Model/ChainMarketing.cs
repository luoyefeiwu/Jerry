namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chain.ChainMarketing")]
    public partial class ChainMarketing
    {
        public long ChainMarketingId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        public long? MaterialId { get; set; }

        [Required]
        [StringLength(500)]
        public string RuleDescribe { get; set; }

        [Required]
        public string Rule { get; set; }

        public DateTime CreateTime { get; set; }

        public int SendFlag { get; set; }

        public int? SendNum { get; set; }

        public DateTime? SendTime { get; set; }

        public Guid UserGuid { get; set; }

        public virtual ChainMarketingSend ChainMarketingSend { get; set; }
    }
}
