namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantDiscountRight")]
    public partial class RestaurantDiscountRight
    {
        [Key]
        public int DiscountRightId { get; set; }

        public Guid RestaurantUser { get; set; }

        public int DiscountID { get; set; }

        public int Status { get; set; }
    }
}
