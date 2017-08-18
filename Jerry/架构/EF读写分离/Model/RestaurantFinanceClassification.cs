namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantFinanceClassification")]
    public partial class RestaurantFinanceClassification
    {
        [Key]
        public Guid RestaurantFinanceClassificationGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string RestaurantFinanceClassificationName { get; set; }

        public bool AttributeFlag { get; set; }
    }
}
