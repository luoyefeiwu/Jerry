namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaStatisticsSet")]
    public partial class RestaurantAreaStatisticsSet
    {
        [Key]
        public Guid SysSetId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid AreaId { get; set; }

        public DateTime CrateTime { get; set; }

        public int IsRevered { get; set; }

        public int IsRRevered { get; set; }
    }
}
