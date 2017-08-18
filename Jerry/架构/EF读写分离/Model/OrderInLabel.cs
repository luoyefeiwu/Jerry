namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderInLabel
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
