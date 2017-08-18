namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.WXPublicAccount")]
    public partial class WXPublicAccount
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string MpName { get; set; }

        [Required]
        [StringLength(100)]
        public string MpId { get; set; }

        [Required]
        [StringLength(100)]
        public string WeiXinId { get; set; }

        [Required]
        [StringLength(20)]
        public string Token { get; set; }

        [Required]
        [StringLength(50)]
        public string AppId { get; set; }

        [Required]
        [StringLength(50)]
        public string AppSecret { get; set; }

        [Required]
        public string CustomMenuBody { get; set; }

        public string SceneIdUseStatus { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
