namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderInLabels
    {
        [Key]
        [Column(Order = 0)]
        public Guid OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LabelId { get; set; }

        public Guid RestaurantId { get; set; }

        public Guid? CustomerId { get; set; }

        public DateTime MealTime { get; set; }

        public DateTime CreateTime { get; set; }

        public bool OrderFlag { get; set; }
    }
}
