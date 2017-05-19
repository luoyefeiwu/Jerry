namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtChannelCity")]
    public partial class ExtChannelCity
    {
        [Key]
        [Column(Order = 0)]
        public Guid ExternalChannelId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        public virtual ExtChannel ExtChannel { get; set; }
    }
}
