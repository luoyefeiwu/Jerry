namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingOrdination")]
    public partial class MarketingOrdination
    {
        public int Id { get; set; }

        public Guid MarketingId { get; set; }

        [StringLength(500)]
        public string RFMClassifiyIds { get; set; }

        [StringLength(500)]
        public string CustomerAliasClassificationIds { get; set; }

        public bool CustomerLockFlag { get; set; }

        public bool CustomerActiveFlag { get; set; }

        public bool CustomerSleepFlag { get; set; }

        public bool CustomerRunAwayFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string UserChannelOrdination { get; set; }

        public int? AheadOfScheduleTime { get; set; }

        public DateTime? SettingTime { get; set; }
    }
}
