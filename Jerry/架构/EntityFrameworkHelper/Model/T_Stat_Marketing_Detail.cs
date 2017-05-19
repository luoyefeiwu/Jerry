namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_Marketing_Detail
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

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string StatDay { get; set; }

        [Key]
        [Column(Order = 7)]
        public Guid MarketingClassGuid { get; set; }

        public long? SendAmount { get; set; }

        public long? UseAmount { get; set; }

        public double? HaveRate { get; set; }

        public long? OrderAmount { get; set; }

        public decimal? OrderMoney { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool CouponFlag { get; set; }

        [Key]
        [Column(Order = 9)]
        public Guid MarketingId { get; set; }
    }
}
