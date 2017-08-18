namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RestaurantDiscount
    {
        [Key]
        public int DiscountID { get; set; }

        public Guid RestaurantGuid { get; set; }

        [StringLength(100)]
        public string DiscountNote { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public Guid Creator { get; set; }

        public Guid Updator { get; set; }

        public int status { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
