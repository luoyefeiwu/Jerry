namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentInRestaurant")]
    public partial class AgentInRestaurant
    {
        [Key]
        [Column(Order = 0)]
        public Guid AgentID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        public int AuditingFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime Updatetime { get; set; }

        public bool FreezeFlag { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
