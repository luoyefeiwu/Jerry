namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.WXCustomer")]
    public partial class WXCustomer
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string OpenId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        public bool Subscribed { get; set; }

        public Guid? CustomerCreditId { get; set; }

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

        public DateTime LastVisitTime { get; set; }

        public virtual CustomerCredit CustomerCredit { get; set; }
    }
}
