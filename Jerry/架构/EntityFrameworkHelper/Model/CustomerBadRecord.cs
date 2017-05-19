namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerBadRecord")]
    public partial class CustomerBadRecord
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerID { get; set; }

        [Required]
        [StringLength(200)]
        public string BadRecord { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantID { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
