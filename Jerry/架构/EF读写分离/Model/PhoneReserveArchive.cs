namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneReserveArchive")]
    public partial class PhoneReserveArchive
    {
        [Key]
        public Guid PhoneReserveId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        public int Number { get; set; }

        public Guid CreatorId { get; set; }

        public Guid OperatorId { get; set; }

        public Guid? OrderGuid { get; set; }

        public int Status { get; set; }

        public DateTime CreateTime { get; set; }

        public bool Missed { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }
    }
}
