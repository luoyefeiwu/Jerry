namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phone")]
    public partial class Phone
    {
        [Key]
        public Guid PhoneGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid CustomerGuid { get; set; }

        public Guid? CustomerCreditId { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public bool ActivityStateFlag { get; set; }

        public bool Authenticated { get; set; }

        public bool MobileFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual CustomerCredit CustomerCredit { get; set; }
    }
}
