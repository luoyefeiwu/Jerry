namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantCustomerAutomaticClassification")]
    public partial class RestaurantCustomerAutomaticClassification
    {
        [Key]
        [Column(Order = 0)]
        public Guid RestaurantID { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RFMClassifiyId { get; set; }

        public int BeginDay { get; set; }

        public int EndDay { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual RestaurantRFMClassification RestaurantRFMClassification { get; set; }
    }
}
