namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SmsSendStateRecord")]
    public partial class SmsSendStateRecord
    {
        public int ID { get; set; }

        public Guid MarketingGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public bool isMarketing { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string SendPhone { get; set; }

        public DateTime SendTime { get; set; }

        [Required]
        [StringLength(1024)]
        public string SmsContent { get; set; }

        public int SmsCount { get; set; }

        public Guid? SenderID { get; set; }

        public bool Success { get; set; }

        public int RecordCountID { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestap { get; set; }

        public Guid? CustomerId { get; set; }

        public int? SourceType { get; set; }

        [StringLength(50)]
        public string SourceId { get; set; }

        public virtual Marketing Marketing { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
