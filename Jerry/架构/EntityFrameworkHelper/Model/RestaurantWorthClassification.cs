namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantWorthClassification")]
    public partial class RestaurantWorthClassification
    {
        public Guid RestaurantWorthClassificationId { get; set; }

        [Required]
        [StringLength(50)]
        public string RestaurantWorthClassificationName { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
