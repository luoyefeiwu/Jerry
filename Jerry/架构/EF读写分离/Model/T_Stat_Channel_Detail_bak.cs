namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_Channel_Detail_bak
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
        public Guid RestaurantUserGuid { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string StatNo { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string StatYear { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string StatMonth { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string StatDay { get; set; }

        public long? CurMonthEffectiveMember { get; set; }

        public double? CurMonthEffectiveRate { get; set; }

        public long? SleepingMember { get; set; }

        public double? SleepingRate { get; set; }

        public long? OutFlowMember { get; set; }

        public double? OutFlowRate { get; set; }

        public long? MemberCount { get; set; }

        public double? MemberRate { get; set; }

        public long? MemberTotal { get; set; }

        public decimal? MemberTotalMoney { get; set; }

        public long? OrderTotal { get; set; }

        public decimal? OrderTotalMoney { get; set; }

        public long? OrderPeopleTotal { get; set; }

        public long? SelfOrderTotal { get; set; }

        public long? SelfPeopleTotal { get; set; }

        public decimal? SelfOrderTotalMoney { get; set; }

        public long? OtherOrderTotal { get; set; }

        public long? OtherPeopleTotal { get; set; }

        public decimal? OtherOrderTotalMoney { get; set; }

        public long? DingCanTaiOrderTotal { get; set; }

        public long? DingCanTaiPeopleTotal { get; set; }

        public decimal? DingCanTaiOrderTotalMoney { get; set; }

        public long? OtherReceiveOrderTotal { get; set; }

        public long? OtherReceivePeopleTotal { get; set; }

        public decimal? OtherReceiveOrderTotalMoney { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public long? OrderDeskTotal { get; set; }

        public double? OrderCommission { get; set; }

        public int? NewCustomerNum { get; set; }

        public double? NewCustomerCommission { get; set; }

        public int? MealsNum { get; set; }

        public decimal? SpendAvg { get; set; }

        public decimal? DeskSpendAvg { get; set; }

        public Guid? RestaurantMealsTimeClassificationID { get; set; }

        [Key]
        [Column(Order = 8)]
        public long ChannelDetailId { get; set; }

        public int? ExistsAmountMealsNum { get; set; }

        public int? ExistsAmountOrderDeskNum { get; set; }

        public int? AllocationNumber { get; set; }

        public double? AllocationRate { get; set; }
    }
}
