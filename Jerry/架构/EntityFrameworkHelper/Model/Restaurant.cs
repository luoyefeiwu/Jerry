namespace EntityFrameworkHelper.Model
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
            AgentInRestaurant = new HashSet<AgentInRestaurant>();
            AgentInRestaurantRejectedRecord = new HashSet<AgentInRestaurantRejectedRecord>();
            Customer = new HashSet<Customer>();
            CustomerAliasClassification = new HashSet<CustomerAliasClassification>();
            CustomerAliasClassificationInRestaurantRFM = new HashSet<CustomerAliasClassificationInRestaurantRFM>();
            CustomerBadRecord = new HashSet<CustomerBadRecord>();
            CustomerSurveyClassification = new HashSet<CustomerSurveyClassification>();
            Order = new HashSet<Order>();
            OrderRemarkLabel = new HashSet<OrderRemarkLabel>();
            Phone = new HashSet<Phone>();
            ResCuisine = new HashSet<ResCuisine>();
            ReserveOrder = new HashSet<ReserveOrder>();
            MaterialClassification = new HashSet<MaterialClassification>();
            Material = new HashSet<Material>();
            QrCode = new HashSet<QrCode>();
            QrCodeLog = new HashSet<QrCodeLog>();
            QrCodeStat = new HashSet<QrCodeStat>();
            RestaurantUser = new HashSet<RestaurantUser>();
            RestaurantPhone = new HashSet<RestaurantPhone>();
            RestaurantArea = new HashSet<RestaurantArea>();
            RestaurantAreaDesk = new HashSet<RestaurantAreaDesk>();
            RestaurantCustomerAutomaticClassification = new HashSet<RestaurantCustomerAutomaticClassification>();
            RestaurantMealsTime = new HashSet<RestaurantMealsTime>();
            RestaurantProduct = new HashSet<RestaurantProduct>();
            SmsSendStateRecord = new HashSet<SmsSendStateRecord>();
            UserLoginLog = new HashSet<UserLoginLog>();
            UserQuit = new HashSet<UserQuit>();
            CityBusinessDistrict = new HashSet<CityBusinessDistrict>();
            RestaurantClassification = new HashSet<RestaurantClassification>();
            RestaurantMealsTimeClassification = new HashSet<RestaurantMealsTimeClassification>();
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
        public virtual ICollection<AgentInRestaurant> AgentInRestaurant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInRestaurantRejectedRecord> AgentInRestaurantRejectedRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAliasClassification> CustomerAliasClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAliasClassificationInRestaurantRFM> CustomerAliasClassificationInRestaurantRFM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerBadRecord> CustomerBadRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSurveyClassification> CustomerSurveyClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderRemarkLabel> OrderRemarkLabel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phone> Phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResCuisine> ResCuisine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReserveOrder> ReserveOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialClassification> MaterialClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Material { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QrCode> QrCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QrCodeLog> QrCodeLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QrCodeStat> QrCodeStat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantUser> RestaurantUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantPhone> RestaurantPhone { get; set; }

        public virtual RestaurantOpen RestaurantOpen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantArea> RestaurantArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantAreaDesk> RestaurantAreaDesk { get; set; }

        public virtual RestaurantBasicInfo RestaurantBasicInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantCustomerAutomaticClassification> RestaurantCustomerAutomaticClassification { get; set; }

        public virtual RestaurantLicense RestaurantLicense { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMealsTime> RestaurantMealsTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantProduct> RestaurantProduct { get; set; }

        public virtual RestaurantRFMverage RestaurantRFMverage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SmsSendStateRecord> SmsSendStateRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLoginLog> UserLoginLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserQuit> UserQuit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityBusinessDistrict> CityBusinessDistrict { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantClassification> RestaurantClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMealsTimeClassification> RestaurantMealsTimeClassification { get; set; }
    }
}
