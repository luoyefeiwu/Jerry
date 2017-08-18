namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerMergeLog")]
    public partial class CustomerMergeLog
    {
        public long CustomerMergeLogId { get; set; }

        public Guid ACustomerId { get; set; }

        public Guid BCustomerId { get; set; }

        public Guid TargetCustomerId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
