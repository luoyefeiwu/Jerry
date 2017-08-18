namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserPhone")]
    public partial class UserPhone
    {
        public long UserPhoneId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        public Guid UserGuid { get; set; }

        public bool MobileFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public bool Authenticated { get; set; }

        public virtual User User { get; set; }
    }
}
