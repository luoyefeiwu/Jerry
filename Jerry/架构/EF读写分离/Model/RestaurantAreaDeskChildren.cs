namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaDeskChildren")]
    public partial class RestaurantAreaDeskChildren
    {
        [Key]
        public int DeskChildrenId { get; set; }

        public Guid DeskGuid { get; set; }

        public Guid DeskChildrenGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid AreaGuid { get; set; }

        public Guid ParentAreaGuid { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }

        public bool Status { get; set; }

        public Guid RestaurantUserGuid { get; set; }
    }
}
