namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderPersonalizedPic")]
    public partial class OrderPersonalizedPic
    {
        public int Id { get; set; }

        public Guid OrderGuid { get; set; }

        [Required]
        [StringLength(500)]
        public string ResourcePath { get; set; }

        public int Way { get; set; }

        public int Status { get; set; }

        public Guid CreatorGuid { get; set; }

        public DateTime Createtime { get; set; }

        public Guid? UpdatorGuid { get; set; }

        public DateTime? Updatetime { get; set; }
    }
}
