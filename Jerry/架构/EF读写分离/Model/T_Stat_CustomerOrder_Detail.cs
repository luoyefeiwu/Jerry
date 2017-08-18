namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_CustomerOrder_Detail
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RFMClassifiyId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentId { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(4)]
        public string StatYear { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string StatMonth { get; set; }

        public long? OrderTotal { get; set; }

        public long? OrderAmount { get; set; }

        public double? OrderRate { get; set; }

        public decimal? OredeMoney { get; set; }

        [Key]
        [Column(Order = 8)]
        public Guid CustomerClassifionId { get; set; }

        [StringLength(20)]
        public string Title { get; set; }
    }
}
