namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.MessageNotice")]
    public partial class MessageNotice
    {
        public Guid MessageNoticeId { get; set; }

        public Guid CustomerGuid { get; set; }

        public int SourceType { get; set; }

        [StringLength(50)]
        public string SourceId { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
