namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chain.ChainMarketingSend")]
    public partial class ChainMarketingSend
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ChainMarketingId { get; set; }

        [Required]
        public string OpenIds { get; set; }

        public int SendFlag { get; set; }

        public string Message { get; set; }

        public virtual ChainMarketing ChainMarketing { get; set; }
    }
}
