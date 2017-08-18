namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Restaurant")]
    public partial class Restaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restaurant()
        {
            AgentInRestaurants = new HashSet<AgentInRestaurant>();
            AgentInRestaurantRejectedRecords = new HashSet<AgentInRestaurantRejectedRecord>();
            Customers = new HashSet<Customer>();
            CustomerAliasClassifications = new HashSet<CustomerAliasClassification>();
            CustomerAliasClassificationInRestaurantRFMs = new HashSet<CustomerAliasClassificationInRestaurantRFM>();
            CustomerBadRecords = new HashSet<CustomerBadRecord>();
            CustomerSurveyClassifications = new HashSet<CustomerSurveyClassification>();
            Orders = new HashSet<Order>();
            OrderRemarkLabels = new HashSet<OrderRemarkLabel>();
            Phones = new HashSet<Phone>();
            ResCuisines = new HashSet<ResCuisine>();
            ReserveOrders = new HashSet<ReserveOrder>();
            MaterialClassifications = new HashSet<MaterialClassification>();
            Materials = new HashSet<Material>();
            QrCodes = new HashSet<QrCode>();
            QrCodeLogs = new HashSet<QrCodeLog>();
            QrCodeStats = new HashSet<QrCodeStat>();
            RestaurantUsers = new HashSet<RestaurantUser>();
            RestaurantPhones = new HashSet<RestaurantPhone>();
            RestaurantAreas = new HashSet<RestaurantArea>();
            RestaurantAreaDesks = new HashSet<RestaurantAreaDesk>();
            RestaurantCustomerAutomaticClassifications = new HashSet<RestaurantCustomerAutomaticClassification>();
            RestaurantMealsTimes = new HashSet<RestaurantMealsTime>();
            RestaurantProducts = new HashSet<RestaurantProduct>();
            SmsSendStateRecords = new HashSet<SmsSendStateRecord>();
            UserLoginLogs = new HashSet<UserLoginLog>();
            UserQuits = new HashSet<UserQuit>();
            CityBusinessDistricts = new HashSet<CityBusinessDistrict>();
            RestaurantClassifications = new HashSet<RestaurantClassification>();
            RestaurantMealsTimeClassifications = new HashSet<RestaurantMealsTimeClassification>();
        }

        [Key]
        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string RestaurantName { get; set; }

        public int CityId { get; set; }

        public decimal Balance { get; set; }

        public Guid? ParentGuid { get; set; }

        public bool FreezeFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool NavigationSMSFlag { get; set; }

        public bool OrderToInformSMSFlag { get; set; }

        public bool NetworkReservationFlag { get; set; }

        public bool AveragespendFlag { get; set; }

        public bool ExpendamountFlag { get; set; }

        public int ProvinceId { get; set; }

        public int AreaId { get; set; }

        public bool MultipleShopFlag { get; set; }

        public decimal CommissionsAndDiscounts { get; set; }

        public decimal AllOrderNum { get; set; }

        public decimal MonetaryValueExpendamount { get; set; }

        public decimal MonetaryValueAverageSpend { get; set; }

        public Guid? AgentID { get; set; }

        public DateTime? RedirectionOperatorDate { get; set; }

        public bool AcceptOpenMealBookingFlag { get; set; }

        public bool OpenMp { get; set; }

        public int UnReciveChannelOrderNum { get; set; }

        public bool recommendation { get; set; }

        public int NotActiveDay { get; set; }

        public int SmsSendWithDeskIdType { get; set; }

        public bool TurnDeskUnabledForApp { get; set; }

        public bool AsycUpdateOrderDeskRemark { get; set; }

        public bool? SmsSendWithUserServiceFlag { get; set; }

        public bool? OnlineBookingFlag { get; set; }

        public bool SmsSendWithLostOrderMealTelFlag { get; set; }

        public bool HideExpirTime { get; set; }

        public virtual Agent Agent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInRestaurant> AgentInRestaurants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInRestaurantRejectedRecord> AgentInRestaurantRejectedRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAliasClassification> CustomerAliasClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAliasClassificationInRestaurantRFM> CustomerAliasClassificationInRestaurantRFMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerBadRecord> CustomerBadRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSurveyClassification> CustomerSurveyClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRemarkLabel> OrderRemarkLabels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phone> Phones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResCuisine> ResCuisines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReserveOrder> ReserveOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialClassification> MaterialClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Materials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QrCode> QrCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QrCodeLog> QrCodeLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QrCodeStat> QrCodeStats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantUser> RestaurantUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantPhone> RestaurantPhones { get; set; }

        public virtual RestaurantOpen RestaurantOpen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantArea> RestaurantAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantAreaDesk> RestaurantAreaDesks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantCustomerAutomaticClassification> RestaurantCustomerAutomaticClassifications { get; set; }

        public virtual RestaurantLicense RestaurantLicense { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMealsTime> RestaurantMealsTimes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantProduct> RestaurantProducts { get; set; }

        public virtual RestaurantRFMverage RestaurantRFMverage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SmsSendStateRecord> SmsSendStateRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLoginLog> UserLoginLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserQuit> UserQuits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityBusinessDistrict> CityBusinessDistricts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantClassification> RestaurantClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMealsTimeClassification> RestaurantMealsTimeClassifications { get; set; }
    }
}
