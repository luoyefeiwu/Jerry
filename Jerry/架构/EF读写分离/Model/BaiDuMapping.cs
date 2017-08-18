namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiDuMapping")]
    public partial class BaiDuMapping
    {
        public Guid restaurantId { get; set; }

        [Required]
        [StringLength(200)]
        public string channelId { get; set; }

        public int telindex { get; set; }

        public DateTime? createTime { get; set; }

        public bool deleteSign { get; set; }

        [Key]
        public Guid MapID { get; set; }
    }
}
