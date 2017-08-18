namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.WXUserSendRecord")]
    public partial class WXUserSendRecord
    {
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string OpenId { get; set; }

        public Guid RestaurantId { get; set; }

        public Guid ReceiveUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string ReceiveUserName { get; set; }

        [Required]
        [StringLength(30)]
        public string ReceiveUserPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string NickName { get; set; }

        [Required]
        [StringLength(1500)]
        public string MsgContent { get; set; }

        public bool Successed { get; set; }

        public int SendType { get; set; }

        public Guid? SourceId { get; set; }

        public Guid? CustomerId { get; set; }

        public DateTime SendTime { get; set; }
    }
}
