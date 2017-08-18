namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAssginStat")]
    public partial class CustomerAssginStat
    {
        [Key]
        [Column(Order = 0)]
        public Guid SourceID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TargetID { get; set; }

        public int AssignedNum { get; set; }

        public int OpenNum { get; set; }
    }
}
