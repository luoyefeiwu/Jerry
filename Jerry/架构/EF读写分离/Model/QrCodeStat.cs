namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.QrCodeStat")]
    public partial class QrCodeStat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long QrCodeId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Date { get; set; }

        public int Count { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual QrCode QrCode { get; set; }
    }
}
