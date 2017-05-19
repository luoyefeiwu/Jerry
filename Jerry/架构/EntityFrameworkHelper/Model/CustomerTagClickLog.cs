namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerTagClickLog")]
    public partial class CustomerTagClickLog
    {
        [Key]
        [Column(Order = 0)]
        public Guid TagGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserGuid { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime CreateTime { get; set; }

        public virtual CustomerTag CustomerTag { get; set; }

        public virtual User User { get; set; }
    }
}
