namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Authorization.ModuleOperation")]
    public partial class ModuleOperation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(60)]
        public string ModuleId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string PageId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OperationId { get; set; }

        public virtual Module Module { get; set; }

        public virtual Operation Operation { get; set; }

        public virtual Page Page { get; set; }
    }
}
