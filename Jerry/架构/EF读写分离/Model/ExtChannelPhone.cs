namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtChannelPhone")]
    public partial class ExtChannelPhone
    {
        [Key]
        [Column(Order = 0)]
        public Guid ExternalChannelId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Phone { get; set; }

        public virtual ExtChannel ExtChannel { get; set; }
    }
}
