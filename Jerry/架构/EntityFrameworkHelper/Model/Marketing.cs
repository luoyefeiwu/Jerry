namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marketing")]
    public partial class Marketing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Marketing()
        {
            MarketingToCustomer = new HashSet<MarketingToCustomer>();
            OrderInMarketing = new HashSet<OrderInMarketing>();
            SmsSendStateRecord = new HashSet<SmsSendStateRecord>();
        }

        [Key]
        public Guid MarketingGuid { get; set; }

        [StringLength(100)]
        public string MarketingTitle { get; set; }

        public Guid MarketingClassificationGuid { get; set; }

        [StringLength(20)]
        public string MarketingClassificationName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Guid RestaurantId { get; set; }

        [StringLength(100)]
        public string RestaurantName { get; set; }

        public Guid SendRestaurantId { get; set; }

        public string SPDescribe { get; set; }

        [Required]
        public string SPRule { get; set; }

        [Required]
        public string SPFormula { get; set; }

        public bool NetWorkFlag { get; set; }

        public bool MeanwhileFlag { get; set; }

        public bool CouponFlag { get; set; }

        public bool LongFlag { get; set; }

        [StringLength(254)]
        public string Img { get; set; }

        public int CheckStateFlag { get; set; }

        public Guid ApplyRestaurantId { get; set; }

        public bool ApplyFlag { get; set; }

        public Guid ApplyUserId { get; set; }

        [StringLength(50)]
        public string ApplyUserName { get; set; }

        public DateTime ApplyTime { get; set; }

        public DateTime? AuditTime { get; set; }

        public Guid AuditRestaurantId { get; set; }

        public Guid AuditUserId { get; set; }

        [StringLength(50)]
        public string AuditUserName { get; set; }

        [StringLength(500)]
        public string MarketingContent { get; set; }

        public int DownNumber { get; set; }

        public int Channel { get; set; }

        public int? BirthdaySendTimeInAdvance { get; set; }

        public Guid? TemplatesId { get; set; }

        public int CustomerNumber { get; set; }

        public int OrderNumber { get; set; }

        public int SendNum { get; set; }

        public decimal Amount { get; set; }

        public decimal Responseivity { get; set; }

        public decimal LoadExpendamount { get; set; }

        public decimal LoadAverageSpend { get; set; }

        public decimal LoadOrderOfFrequency { get; set; }

        public decimal LoadRecentDiningTime { get; set; }

        public decimal RunningExpendamount { get; set; }

        public decimal RunningAverageSpend { get; set; }

        public decimal RunningOrderOfFrequency { get; set; }

        public decimal RunningRecentDiningTime { get; set; }

        public decimal PromoteExpendamount { get; set; }

        public decimal PromoteAverageSpend { get; set; }

        public decimal PromoteOrderOfFrequency { get; set; }

        public decimal PromoteRecentDiningTime { get; set; }

        public bool OperationInPlaceFlag { get; set; }

        public bool FreezeFlag { get; set; }

        public bool IsForSms { get; set; }

        public bool IsSmsForPhone { get; set; }

        public bool IsSmsForMP { get; set; }

        public bool IsForMP { get; set; }

        public bool IsMPReg { get; set; }

        public bool IsMPNotReg { get; set; }

        public long? MaterialId { get; set; }

        public int? BirthdaySendTime { get; set; }

        public int MpSendNum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingToCustomer> MarketingToCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderInMarketing> OrderInMarketing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SmsSendStateRecord> SmsSendStateRecord { get; set; }
    }
}
