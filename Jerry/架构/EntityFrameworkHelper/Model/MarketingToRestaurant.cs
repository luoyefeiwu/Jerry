namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingToRestaurant")]
    public partial class MarketingToRestaurant
    {
        [Key]
        [Column(Order = 0)]
        public Guid MarketingId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ChainId { get; set; }
    }
}
