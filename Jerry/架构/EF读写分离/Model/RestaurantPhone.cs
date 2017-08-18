namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantPhone")]
    public partial class RestaurantPhone
    {
        public long RestaurantPhoneId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        public bool MobileFlag { get; set; }

        public bool ActivityStateFlag { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
