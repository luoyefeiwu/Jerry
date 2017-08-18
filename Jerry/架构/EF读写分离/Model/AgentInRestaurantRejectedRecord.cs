namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentInRestaurantRejectedRecord")]
    public partial class AgentInRestaurantRejectedRecord
    {
        public int AgentInRestaurantRejectedRecordID { get; set; }

        public Guid AgentID { get; set; }

        public Guid RestaurantGuid { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(254)]
        public string Comments { get; set; }

        public int AgentReasonForRejectionId { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
