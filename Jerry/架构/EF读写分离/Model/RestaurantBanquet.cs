namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantBanquet")]
    public partial class RestaurantBanquet
    {
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int? Sequence { get; set; }

        public bool? FreezeFlag { get; set; }

        public Guid? ParentId { get; set; }

        [Column(TypeName = "text")]
        public string Remarks { get; set; }
    }
}
