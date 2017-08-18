namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantBasicInfo")]
    public partial class RestaurantBasicInfo
    {
        [Key]
        public Guid RestaurantGuid { get; set; }

        [StringLength(10)]
        public string ImportantContacts { get; set; }

        [Required]
        [StringLength(14)]
        public string ImportantMobilePhone { get; set; }

        [StringLength(500)]
        public string TheBus { get; set; }

        public decimal DiningRoomArea { get; set; }

        public decimal AverageSpendBegin { get; set; }

        public decimal AverageSpendEnd { get; set; }

        public int NumberOfRooms { get; set; }

        public int BanquetRoomNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string BusinessLicenseImg { get; set; }

        [Required]
        [StringLength(200)]
        public string CorporateIDCardImg { get; set; }

        [StringLength(200)]
        public string HealthPermitsImg { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(254)]
        public string Address { get; set; }

        [StringLength(50)]
        public string LegalPerson { get; set; }

        [StringLength(50)]
        public string LicensePhone { get; set; }

        [StringLength(100)]
        public string LicenseNumber { get; set; }

        [StringLength(254)]
        public string ApplicationFrom { get; set; }

        public string Chain { get; set; }

        public string Facilities { get; set; }

        public string Pay { get; set; }

        public DateTime? WorkBegin { get; set; }

        public DateTime? WorkEnd { get; set; }

        public double? Longitude { get; set; }

        public double? Latitude { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; }

        [StringLength(50)]
        public string Signer { get; set; }

        [StringLength(50)]
        public string SignerPhone { get; set; }

        [StringLength(500)]
        public string Logo { get; set; }

        [StringLength(100)]
        public string HistoryOrderPath { get; set; }

        [StringLength(100)]
        public string CustomerPath { get; set; }

        public decimal AssessmentScale { get; set; }

        public bool IsPersonalTailor { get; set; }

        [StringLength(200)]
        public string RestaurantOperaSettings { get; set; }

        public bool IsCustomNum { get; set; }

        public bool IsSandtable { get; set; }

        public bool IsWelcomeScreen { get; set; }

        public bool IsPicture { get; set; }

        [StringLength(500)]
        public string DefaultMealTimeJson { get; set; }
    }
}
