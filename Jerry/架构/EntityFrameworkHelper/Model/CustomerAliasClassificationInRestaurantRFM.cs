namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAliasClassificationInRestaurantRFM")]
    public partial class CustomerAliasClassificationInRestaurantRFM
    {
        [Key]
        [Column(Order = 0)]
        public Guid RFMGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CustomerClassificationGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public bool FreezeFlag { get; set; }

        public virtual CustomerAliasClassification CustomerAliasClassification { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual RestaurantRFM RestaurantRFM { get; set; }
    }
}
