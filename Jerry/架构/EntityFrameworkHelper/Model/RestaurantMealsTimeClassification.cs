namespace EntityFrameworkHelper.Model
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
            RestaurantMealsTime = new HashSet<RestaurantMealsTime>();
            RestaurantMealsTimeClassificationInTime = new HashSet<RestaurantMealsTimeClassificationInTime>();
            Restaurant = new HashSet<Restaurant>();
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
        public virtual ICollection<RestaurantMealsTime> RestaurantMealsTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMealsTimeClassificationInTime> RestaurantMealsTimeClassificationInTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}
