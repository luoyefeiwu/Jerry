namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaDeskRelation")]
    public partial class RestaurantAreaDeskRelation
    {
        [Key]
        public int DeskRelationId { get; set; }

        public int TotalDeskPeopleMin { get; set; }

        public Guid RestaurantGuid { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }

        public bool Status { get; set; }

        public Guid RestaurantUserGuid { get; set; }
    }
}
