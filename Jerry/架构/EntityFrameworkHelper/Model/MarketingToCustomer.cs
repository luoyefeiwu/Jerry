namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingToCustomer")]
    public partial class MarketingToCustomer
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MarketingGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public int MakeNumber { get; set; }

        public DateTime? SendTime { get; set; }

        public int SendStateFlag { get; set; }

        public int MaxNumber { get; set; }

        public bool LongFlag { get; set; }

        public bool CouponFlag { get; set; }

        public Guid MarketingClassificationId { get; set; }

        public Guid RestaurantId { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid? TemplatesId { get; set; }

        public decimal LoadExpendamount { get; set; }

        public decimal LoadAverageSpend { get; set; }

        public decimal LoadOrderOfFrequency { get; set; }

        public decimal LoadRecentDiningTime { get; set; }

        [StringLength(1024)]
        public string SmsErrorMsg { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Marketing Marketing { get; set; }
    }
}
