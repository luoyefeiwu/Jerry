namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            CustomerBadRecords = new HashSet<CustomerBadRecord>();
            CustomerDiseases = new HashSet<CustomerDisease>();
            CustomerSurveys = new HashSet<CustomerSurvey>();
            CustomerTags = new HashSet<CustomerTag>();
            MarketingToCustomers = new HashSet<MarketingToCustomer>();
            Orders = new HashSet<Order>();
            Phones = new HashSet<Phone>();
            ReserveOrders = new HashSet<ReserveOrder>();
        }

        [Key]
        public Guid CustomerGuid { get; set; }

        public Guid CustomerClassificationGuid { get; set; }

        public int? NativeCityId { get; set; }

        public int? CurrentCityId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        public bool CustomerGender { get; set; }

        [StringLength(50)]
        public string CustomerUnit { get; set; }

        public DateTime? Birthday { get; set; }

        public bool? BirthdayFlag { get; set; }

        [StringLength(100)]
        public string CustomerRemark { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool LockFlag { get; set; }

        public bool FreezeFlag { get; set; }

        public DateTime? Lastmeal { get; set; }

        public bool CanMarketing { get; set; }

        public Guid RestaurantUserGuid { get; set; }

        [StringLength(100)]
        public string CanNotEat { get; set; }

        public Guid RFMGUID { get; set; }

        public int RFMClassifiyId { get; set; }

        public int RFMClassifiyIdSubclass { get; set; }

        public int? CurMonthStatus { get; set; }

        public int AllOrderNum { get; set; }

        public decimal MonetaryValueExpendamount { get; set; }

        public decimal MonetaryValueAverageSpend { get; set; }

        public int RecentDiningTime { get; set; }

        public int Cancellations { get; set; }

        public int OrderAMealNumber { get; set; }

        public int ActiveOrderOfFrequency { get; set; }

        public decimal ActiveMonetaryValueExpendamount { get; set; }

        public decimal ActiveMonetaryValueAverageSpend { get; set; }

        public int ActiveCancellations { get; set; }

        public int ActiveOrderAMealNumber { get; set; }

        public decimal? DeskSpendAvg { get; set; }

        public int? EffectiveOrderNum { get; set; }

        public decimal? ActiveDeskSpendAvg { get; set; }

        public double? ActiveSpendFrequency { get; set; }

        public decimal? ActiveSpendAbility { get; set; }

        public int? ActiveDeskNum { get; set; }

        public double? SpendFrequency { get; set; }

        public int? RecordCostOrderDeskNum { get; set; }

        public int? RecordCostMealsNum { get; set; }

        public bool IsOpen { get; set; }

        public int ReceiveNum { get; set; }

        public int UnReciveChannelOrderNum { get; set; }

        public int? LabelType { get; set; }

        public DateTime? LabelCreateTime { get; set; }

        [Required]
        [StringLength(1)]
        public string FirstLetter { get; set; }

        public Guid? ResourceOwnerId { get; set; }

        public int? ActiveEffectiveDeskNum { get; set; }

        public int? AllEffectiveDeskNum { get; set; }

        public DateTime? AllocationTime { get; set; }

        public decimal? PointsMoney { get; set; }

        public decimal? ChargeMoney { get; set; }

        public virtual CustomerAliasClassification CustomerAliasClassification { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual RestaurantRFMClassification RestaurantRFMClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerBadRecord> CustomerBadRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerDisease> CustomerDiseases { get; set; }

        public virtual CustomerMultipleCount CustomerMultipleCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSurvey> CustomerSurveys { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerTag> CustomerTags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingToCustomer> MarketingToCustomers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phone> Phones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReserveOrder> ReserveOrders { get; set; }
    }
}
