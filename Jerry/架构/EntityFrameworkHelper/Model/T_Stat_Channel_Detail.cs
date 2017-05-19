namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_Channel_Detail
    {
        public int CityID { get; set; }

        public Guid AgentID { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid RestaurantUserGuid { get; set; }

        [Required]
        [StringLength(10)]
        public string StatNo { get; set; }

        [Required]
        [StringLength(4)]
        public string StatYear { get; set; }

        [Required]
        [StringLength(2)]
        public string StatMonth { get; set; }

        [Required]
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
        public long ChannelDetailId { get; set; }

        public int? ExistsAmountMealsNum { get; set; }

        public int? ExistsAmountOrderDeskNum { get; set; }

        public int? AllocationNumber { get; set; }

        public double? AllocationRate { get; set; }
    }
}
