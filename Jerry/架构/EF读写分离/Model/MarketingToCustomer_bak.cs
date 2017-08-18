namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MarketingToCustomer_bak
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MarketingGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MakeNumber { get; set; }

        public DateTime? SendTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SendStateFlag { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaxNumber { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool LongFlag { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool CouponFlag { get; set; }

        [Key]
        [Column(Order = 8)]
        public Guid MarketingClassificationId { get; set; }

        [Key]
        [Column(Order = 9)]
        public Guid RestaurantId { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime CreateTime { get; set; }

        public Guid? TemplatesId { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal LoadExpendamount { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal LoadAverageSpend { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal LoadOrderOfFrequency { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal LoadRecentDiningTime { get; set; }

        [StringLength(1024)]
        public string SmsErrorMsg { get; set; }
    }
}
