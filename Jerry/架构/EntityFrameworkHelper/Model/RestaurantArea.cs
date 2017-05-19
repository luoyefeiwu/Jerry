namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantArea")]
    public partial class RestaurantArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantArea()
        {
            RestaurantAreaDesk = new HashSet<RestaurantAreaDesk>();
        }

        [Key]
        public Guid AreaGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string AreaName { get; set; }

        public Guid RestaurantGuid { get; set; }

        public int sequence { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool freezeFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantAreaDesk> RestaurantAreaDesk { get; set; }
    }
}
