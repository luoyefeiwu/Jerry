namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDesk_bak
    {
        [Key]
        [Column(Order = 0)]
        public Guid OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderStateId { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid DeskID { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime Mealtime { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid AreaId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(30)]
        public string AreaName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(30)]
        public string DeskName { get; set; }

        [Key]
        [Column(Order = 9)]
        public Guid RestaurantMealsTimeGuid { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime MealtimeDay { get; set; }

        public decimal? AgientProfitMoney { get; set; }

        public Guid? AgentID { get; set; }

        public decimal? ProfitRate { get; set; }

        public decimal? ProfitPrice { get; set; }

        [StringLength(20)]
        public string RestaurantMealsTimeName { get; set; }

        public int? People { get; set; }

        [StringLength(100)]
        public string DeskChangeInfo { get; set; }

        public int? OrderStatusDetail { get; set; }

        public Guid? ModifierId { get; set; }

        public DateTime? ModifyTime { get; set; }

        public int? CancellationType { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsSendSms { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsLockDesk { get; set; }

        [StringLength(100)]
        public string TradeNumber { get; set; }

        public DateTime? TradeTime { get; set; }

        [StringLength(100)]
        public string CancellationRemark { get; set; }

        [StringLength(20)]
        public string ExchangeTableUserName { get; set; }
    }
}
