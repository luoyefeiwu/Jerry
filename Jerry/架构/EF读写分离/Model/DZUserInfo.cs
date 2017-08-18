namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DingZuoApp.DZUserInfo")]
    public partial class DZUserInfo
    {
        [Key]
        public Guid DZUID { get; set; }

        [StringLength(100)]
        public string AccountTel { get; set; }

        [StringLength(20)]
        public string AccountName { get; set; }

        [StringLength(50)]
        public string PWD { get; set; }

        [StringLength(50)]
        public string PayPWD { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public decimal? Point { get; set; }

        public decimal? LockPoint { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string QQAppID { get; set; }

        [StringLength(200)]
        public string WXAppID { get; set; }

        [StringLength(200)]
        public string WBAppID { get; set; }

        [StringLength(200)]
        public string ALIAppID { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? ModifyTime { get; set; }

        [StringLength(1000)]
        public string HeadUrl { get; set; }

        public int? Sex { get; set; }
    }
}
