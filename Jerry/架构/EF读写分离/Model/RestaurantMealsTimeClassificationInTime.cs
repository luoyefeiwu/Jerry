namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantMealsTimeClassificationInTime")]
    public partial class RestaurantMealsTimeClassificationInTime
    {
        public int RestaurantMealsTimeClassificationInTimeId { get; set; }

        public DateTime MealsTime { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public Guid RestaurantMealsTimeClassificationID { get; set; }

        public bool AcrossTheDayFlag { get; set; }

        public virtual RestaurantMealsTimeClassification RestaurantMealsTimeClassification { get; set; }
    }
}
