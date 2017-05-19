namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantRFMverage")]
    public partial class RestaurantRFMverage
    {
        [Key]
        public Guid RestaurantGuid { get; set; }

        public decimal Fvalue { get; set; }

        public decimal Mvalue { get; set; }

        public decimal Rvalue { get; set; }

        public decimal Avlaue { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
