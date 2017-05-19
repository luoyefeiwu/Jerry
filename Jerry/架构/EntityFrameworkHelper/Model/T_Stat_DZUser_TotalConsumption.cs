namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_DZUser_TotalConsumption
    {
        [Key]
        public Guid DZUID { get; set; }

        [StringLength(20)]
        public string AccountName { get; set; }

        [StringLength(50)]
        public string WxNickName { get; set; }

        [StringLength(50)]
        public string AccountTel { get; set; }

        public int SpendingRestaurant { get; set; }

        public int? SpendingMember { get; set; }

        public int? SpendingOrderDesk { get; set; }

        public int? SpendingOrder { get; set; }

        public double? TotalSpending { get; set; }

        public int? TotalOrderOfCancel { get; set; }

        public double? TotalCancelOrderRate { get; set; }

        public DateTime? LastBookingDate { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
