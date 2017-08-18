namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantLicense")]
    public partial class RestaurantLicense
    {
        [Key]
        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string LicenseName { get; set; }

        [Required]
        [StringLength(50)]
        public string LicenseAddr { get; set; }

        [Required]
        [StringLength(50)]
        public string LegalPerson { get; set; }

        [Required]
        [StringLength(100)]
        public string BusinessScope { get; set; }

        [Required]
        [StringLength(50)]
        public string LicenseNumber { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(50)]
        public string LicensePhone { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
