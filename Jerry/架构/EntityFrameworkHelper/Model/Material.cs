namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.Material")]
    public partial class Material
    {
        public long MaterialId { get; set; }

        public long MaterialClassificationId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid CreatorId { get; set; }

        public Guid ModifierId { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(50)]
        public string PicUrl { get; set; }

        public bool PicInContent { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual MaterialClassification MaterialClassification { get; set; }
    }
}
