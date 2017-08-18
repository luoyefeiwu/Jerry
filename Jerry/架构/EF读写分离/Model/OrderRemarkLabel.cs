namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderRemarkLabel")]
    public partial class OrderRemarkLabel
    {
        [Key]
        public long LableId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsHidden { get; set; }

        public bool FreezeFlag { get; set; }

        public int LabelType { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
