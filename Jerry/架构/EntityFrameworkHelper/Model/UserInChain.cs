namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInChain")]
    public partial class UserInChain
    {
        [Key]
        [Column(Order = 0)]
        public Guid UserGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        [StringLength(50)]
        public string RestaurantName { get; set; }

        public Guid? ChainId { get; set; }
    }
}
