namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DstVirtualNum")]
    public partial class DstVirtualNum
    {
        public int id { get; set; }

        public Guid RestaurantId { get; set; }

        [Column("DstVirtualNum")]
        [Required]
        [StringLength(50)]
        public string DstVirtualNum1 { get; set; }

        public bool Status { get; set; }
    }
}
