namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaDeskCost")]
    public partial class RestaurantAreaDeskCost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantAreaDeskCost()
        {
            RestaurantAreaDeskInRestaurantAreaDeskCost = new HashSet<RestaurantAreaDeskInRestaurantAreaDeskCost>();
        }

        public Guid RestaurantAreaDeskCostID { get; set; }

        [Required]
        [StringLength(20)]
        public string RestaurantAreaDeskCostName { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Sequence { get; set; }

        public bool FreezeFlag { get; set; }

        public int ValueType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantAreaDeskInRestaurantAreaDeskCost> RestaurantAreaDeskInRestaurantAreaDeskCost { get; set; }
    }
}
