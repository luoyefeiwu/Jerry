namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.QrCodeLog")]
    public partial class QrCodeLog
    {
        public long QrCodeLogId { get; set; }

        public long QrCodeId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual QrCode QrCode { get; set; }
    }
}
