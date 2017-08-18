namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAssginStatLog")]
    public partial class CustomerAssginStatLog
    {
        public long Id { get; set; }

        public Guid OperatorId { get; set; }

        public bool AllocationType { get; set; }

        public int AssignedNum { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public Guid RestaurantUserId { get; set; }
    }
}
