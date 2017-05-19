namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DingZuoApp.WXDZUserShareLog")]
    public partial class WXDZUserShareLog
    {
        public long Id { get; set; }

        public Guid? DZUID { get; set; }

        public Guid? RestaurantUserId { get; set; }

        [StringLength(100)]
        public string Unionid { get; set; }

        [StringLength(100)]
        public string OpenId { get; set; }

        public DateTime? ShareTime { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        [StringLength(50)]
        public string ShareType { get; set; }

        [StringLength(50)]
        public string WxUName { get; set; }
    }
}
