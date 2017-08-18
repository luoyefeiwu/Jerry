namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Open.RestaurantOpen")]
    public partial class RestaurantOpen
    {
        [Key]
        public Guid RestaurantGuid { get; set; }

        public bool Opened { get; set; }

        public Guid AppId { get; set; }

        [Required]
        [StringLength(50)]
        public string AppSecret { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
