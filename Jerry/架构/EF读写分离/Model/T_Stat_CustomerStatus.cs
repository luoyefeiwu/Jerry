namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_CustomerStatus
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AgentID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string StatNo { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string StatYear { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string StatMonth { get; set; }

        public long ClientAmount { get; set; }

        public long NewClient { get; set; }

        public long WakeUp { get; set; }

        public long Redeem { get; set; }

        public long Sleep { get; set; }

        public long RunOff { get; set; }

        public long ClientStatus { get; set; }

        public Guid? ChainId { get; set; }
    }
}
