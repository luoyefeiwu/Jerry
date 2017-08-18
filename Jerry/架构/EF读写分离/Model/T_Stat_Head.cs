namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_Head
    {
        [Key]
        [Column(Order = 0)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Stat_Year { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Stat_Moth { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CorpType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SmsMarketingMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SmsMarketingProfitMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SmsNoticeMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SmsNoticeProfitMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrderMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrderProfit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProductMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProductProfitMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RechargeMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RechargeProfitMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PayMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Withdrawals_Money { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OtherPayMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OtherInComeMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Archive_Money { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Account_Amount { get; set; }
    }
}
