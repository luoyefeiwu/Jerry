namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.WXUser")]
    public partial class WXUser
    {
        [Key]
        [StringLength(100)]
        public string OpenId { get; set; }

        public Guid? RestaurantId { get; set; }

        public Guid? RestaurantUserId { get; set; }

        public bool Subscribed { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string RemarkName { get; set; }

        [StringLength(500)]
        public string HeadUrl { get; set; }

        public int? Gender { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public string Signature { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
