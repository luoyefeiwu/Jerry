namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDesks = new HashSet<OrderDesk>();
            OrderInMarketings = new HashSet<OrderInMarketing>();
        }

        [Key]
        public Guid OrderGuid { get; set; }

        public Guid? CustomerGuid { get; set; }

        public Guid UserSeviceGuid { get; set; }

        public Guid UserOwnerGuid { get; set; }

        public Guid RestaurantMealsTimeGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        [StringLength(1000)]
        public string Requirement { get; set; }

        public DateTime CreateTime { get; set; }

        public decimal Deposit { get; set; }

        public int People { get; set; }

        [StringLength(20)]
        public string CustomerPhoneNumber { get; set; }

        public DateTime MealtimeDay { get; set; }

        public bool? LockPositionSeviceGuid { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerUnit { get; set; }

        public bool CustomerGender { get; set; }

        public Guid? CustomerClassificationGuid { get; set; }

        public Guid RestaurantMealsTimeClassificationID { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerClassificationName { get; set; }

        public int OrderType { get; set; }

        public Guid RFM { get; set; }

        [StringLength(20)]
        public string UserSeviceName { get; set; }

        [StringLength(20)]
        public string UserOwnerName { get; set; }

        public int RFMClassifiyId { get; set; }

        public Guid AgentId { get; set; }

        public int CityId { get; set; }

        public decimal AggregateAmount { get; set; }

        public int OrderStatus { get; set; }

        public int MultiTablingFlag { get; set; }

        [StringLength(20)]
        public string RestaurantMealsTimeName { get; set; }

        public DateTime MealTime { get; set; }

        public int RFMSubClassifiyId { get; set; }

        public int? CancellationType { get; set; }

        public Guid? ApplyUserId { get; set; }

        public bool IsSendSms { get; set; }

        public int? CommissionType { get; set; }

        public double? CommissionValue { get; set; }

        public bool? SmsSendWithDeskId { get; set; }

        public bool IsExceptionOrder { get; set; }

        public bool? CheckedExceptionOrder { get; set; }

        public bool IsChekced { get; set; }

        public bool IsImportant { get; set; }

        [StringLength(40)]
        public string TemporaryNumber { get; set; }

        [StringLength(50)]
        public string ApplyUserName { get; set; }

        public bool? IsClicked { get; set; }

        public Guid? DzUserId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual RestaurantMealsTime RestaurantMealsTime { get; set; }

        public virtual RestaurantRFM RestaurantRFM { get; set; }

        public virtual RestaurantRFMClassification RestaurantRFMClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDesk> OrderDesks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderInMarketing> OrderInMarketings { get; set; }
    }
}
