namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAnniversary")]
    public partial class CustomerAnniversary
    {
        [Key]
        public Guid AnniversaryGuid { get; set; }

        public Guid CustomerGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public DateTime AnniversaryDate { get; set; }

        public bool AnniversaryFlag { get; set; }

        public int AnniversaryTypeId { get; set; }

        [Required]
        [StringLength(20)]
        public string Relations { get; set; }
    }
}
