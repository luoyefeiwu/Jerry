namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerInfoChange")]
    public partial class CustomerInfoChange
    {
        public long CustomerInfoChangeId { get; set; }

        public Guid? UserId { get; set; }

        public Guid CustomerId { get; set; }

        public int ChangeType { get; set; }

        public int OperationType { get; set; }

        [StringLength(500)]
        public string OriginaValue { get; set; }

        [StringLength(500)]
        public string TargetValue { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
