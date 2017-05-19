namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaDeskRelationDetail")]
    public partial class RestaurantAreaDeskRelationDetail
    {
        [Key]
        public int DeskRelationDetailId { get; set; }

        public Guid DeskGuid { get; set; }

        public int DeskRelationId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid AreaGuid { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }

        public bool Status { get; set; }

        public Guid RestaurantUserGuid { get; set; }
    }
}
