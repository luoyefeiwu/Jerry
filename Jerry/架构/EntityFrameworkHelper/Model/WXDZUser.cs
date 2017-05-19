namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DingZuoApp.WXDZUser")]
    public partial class WXDZUser
    {
        [Key]
        [StringLength(100)]
        public string OpenId { get; set; }

        public Guid? SourceId { get; set; }

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
