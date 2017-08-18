namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_Order_Detail
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

        public long? BreakFastOrderAmount { get; set; }

        public double? BreakFastOrderRate { get; set; }

        public long? LunchOrderAmount { get; set; }

        public double? LunchOrderRate { get; set; }

        public long? DinnerOrderAmount { get; set; }

        public double? DinnerOrderRate { get; set; }

        public long? SupperOrderAmount { get; set; }

        public double? SupperOrderRate { get; set; }

        public long? CouponOrderAmount { get; set; }

        public long? ChannelAmount { get; set; }

        public long? OtherAmount { get; set; }

        public long? GuestAmount { get; set; }

        public double? ChannelOrderRate { get; set; }

        public long? ChannelOrderMoney { get; set; }

        public DateTime StatDate { get; set; }

        public long Amount { get; set; }

        public double? OtherRate { get; set; }

        public long? OtherMoney { get; set; }

        public double? CouponOrderRate { get; set; }

        public long? CouponOrderMoney { get; set; }

        public int? OrderNum { get; set; }

        public int? OrderDeskNum { get; set; }

        public int? MealsNum { get; set; }

        public decimal? SpendAmount { get; set; }

        public decimal? SpendAvg { get; set; }

        public decimal? DeskSpendAvg { get; set; }

        public int? RecordCostOrderDeskNum { get; set; }
    }
}
