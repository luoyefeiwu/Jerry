namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order0313
    {
        [Key]
        [Column(Order = 0)]
        public Guid OrderGuid { get; set; }

        public Guid? CustomerGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UserSeviceGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UserOwnerGuid { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid RestaurantMealsTimeGuid { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid RestaurantGuid { get; set; }

        [StringLength(1000)]
        public string Requirement { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CreateTime { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal Deposit { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int People { get; set; }

        [StringLength(20)]
        public string CustomerPhoneNumber { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime MealtimeDay { get; set; }

        public bool? LockPositionSeviceGuid { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerUnit { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool CustomerGender { get; set; }

        public Guid? CustomerClassificationGuid { get; set; }

        [Key]
        [Column(Order = 10)]
        public Guid RestaurantMealsTimeClassificationID { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string CustomerClassificationName { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderType { get; set; }

        [Key]
        [Column(Order = 13)]
        public Guid RFM { get; set; }

        [StringLength(20)]
        public string UserSeviceName { get; set; }

        [StringLength(20)]
        public string UserOwnerName { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RFMClassifiyId { get; set; }

        [Key]
        [Column(Order = 15)]
        public Guid AgentId { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal AggregateAmount { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderStatus { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MultiTablingFlag { get; set; }

        [StringLength(20)]
        public string RestaurantMealsTimeName { get; set; }

        [Key]
        [Column(Order = 20)]
        public DateTime MealTime { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RFMSubClassifiyId { get; set; }

        public int? CancellationType { get; set; }

        public Guid? ApplyUserId { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsSendSms { get; set; }

        public int? CommissionType { get; set; }

        public double? CommissionValue { get; set; }

        public bool? SmsSendWithDeskId { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool IsExceptionOrder { get; set; }

        public bool? CheckedExceptionOrder { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool IsChekced { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool IsImportant { get; set; }

        [StringLength(40)]
        public string TemporaryNumber { get; set; }

        [StringLength(50)]
        public string ApplyUserName { get; set; }

        public bool? IsClicked { get; set; }
    }
}
