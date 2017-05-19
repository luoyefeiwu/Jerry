namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SendSMS
    {
        [Key]
        public int SmsId { get; set; }

        public int CityID { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        public Guid AgentID { get; set; }

        public Guid MarketingGuid { get; set; }

        public Guid ParentGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public int SmsType { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(20)]
        public string SendPhone { get; set; }

        public DateTime? SendTime { get; set; }

        [StringLength(1024)]
        public string SmsContent { get; set; }

        public int? SmsCount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SmsPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProfitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProfitRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AgientProfitMoney { get; set; }

        public Guid? SiteId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SiteProfitRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SiteProfitMoney { get; set; }
    }
}
