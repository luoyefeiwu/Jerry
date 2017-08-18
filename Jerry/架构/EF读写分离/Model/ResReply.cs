namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.ResReply")]
    public partial class ResReply
    {
        public long ResReplyId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public int ResReplyType { get; set; }

        public Guid CreatorId { get; set; }

        public Guid ModifierId { get; set; }

        public int MessageType { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BeginDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
