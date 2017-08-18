namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaDeskPic")]
    public partial class RestaurantAreaDeskPic
    {
        [Key]
        public int DeskPicId { get; set; }

        public Guid DeskGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public int sequence { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; }

        [StringLength(500)]
        public string ImageUrlBig { get; set; }

        public bool Status { get; set; }

        public Guid? RestaurantUserGuid { get; set; }
    }
}
