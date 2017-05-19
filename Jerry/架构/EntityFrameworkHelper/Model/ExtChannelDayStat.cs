namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtChannelDayStat")]
    public partial class ExtChannelDayStat
    {
        [Key]
        public long ExtChannelDayReportId { get; set; }

        public Guid ExternalChannelId { get; set; }

        public int CityId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int RestaurantNum { get; set; }

        public double OrderNum { get; set; }

        public double CostMoney { get; set; }

        public double ReturnCommissionMoney { get; set; }
    }
}
