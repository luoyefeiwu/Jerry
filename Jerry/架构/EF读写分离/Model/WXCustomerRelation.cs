namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.WXCustomerRelation")]
    public partial class WXCustomerRelation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string OpenId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        public Guid SubRestaurantGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CustomerGuid { get; set; }
    }
}
