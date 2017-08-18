namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaDeskClassification")]
    public partial class RestaurantAreaDeskClassification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantAreaDeskClassification()
        {
            RestaurantAreaDesks = new HashSet<RestaurantAreaDesk>();
        }

        public Guid RestaurantAreaDeskClassificationID { get; set; }

        [Required]
        [StringLength(20)]
        public string RestaurantAreaDeskClassificationName { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Sequence { get; set; }

        public bool FreezeFlag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantAreaDesk> RestaurantAreaDesks { get; set; }
    }
}
