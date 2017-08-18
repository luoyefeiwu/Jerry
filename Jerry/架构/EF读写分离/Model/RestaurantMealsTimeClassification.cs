namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantMealsTimeClassification")]
    public partial class RestaurantMealsTimeClassification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantMealsTimeClassification()
        {
            RestaurantMealsTimes = new HashSet<RestaurantMealsTime>();
            RestaurantMealsTimeClassificationInTimes = new HashSet<RestaurantMealsTimeClassificationInTime>();
            Restaurants = new HashSet<Restaurant>();
        }

        public Guid RestaurantMealsTimeClassificationID { get; set; }

        [Required]
        [StringLength(20)]
        public string RestaurantMealsTimeClassificationName { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Sequence { get; set; }

        public bool FreezeFlag { get; set; }

        public int TypeFlag { get; set; }

        public bool DefaultFlag { get; set; }

        public TimeSpan? StartTime { get; set; }

        public TimeSpan? EndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMealsTime> RestaurantMealsTimes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMealsTimeClassificationInTime> RestaurantMealsTimeClassificationInTimes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
