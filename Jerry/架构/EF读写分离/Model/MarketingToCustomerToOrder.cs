namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingToCustomerToOrder")]
    public partial class MarketingToCustomerToOrder
    {
        [Key]
        [Column(Order = 0)]
        public Guid MarketingId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OrderId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CustomerId { get; set; }
    }
}
