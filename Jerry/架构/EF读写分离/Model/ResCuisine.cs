namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResCuisine")]
    public partial class ResCuisine
    {
        public Guid ResCuisineId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public int CuisineLevel1 { get; set; }

        public int CuisineLevel2 { get; set; }

        public virtual Cuisine Cuisine { get; set; }

        public virtual Cuisine Cuisine1 { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
