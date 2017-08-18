namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantMealsTime")]
    public partial class RestaurantMealsTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantMealsTime()
        {
            Orders = new HashSet<Order>();
        }

        public Guid RestaurantMealsTimeID { get; set; }

        public Guid? RestaurantID { get; set; }

        public Guid RestaurantMealsTimeClassificationID { get; set; }

        public int Weekday { get; set; }

        public Guid? UserID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreateTime { get; set; }

        public bool FreezeFlag { get; set; }

        public DateTime UpdateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual RestaurantMealsTimeClassification RestaurantMealsTimeClassification { get; set; }

        public virtual User User { get; set; }
    }
}
