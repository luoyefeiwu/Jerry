namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_Restaurant_Total
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        [StringLength(300)]
        public string RestaurantName { get; set; }

        public DateTime? SignDate { get; set; }

        public int? SignDays { get; set; }

        public DateTime? OpenDate { get; set; }

        public string TheBus { get; set; }

        [StringLength(10)]
        public string ImportantContacts { get; set; }

        [StringLength(14)]
        public string ImportantMobilePhone { get; set; }

        public int? HighManageNum { get; set; }

        public int? CustomerManagNum { get; set; }

        public int? UsingAppNum { get; set; }

        public int? YesterdayOrderNum { get; set; }

        public int? BeforeYesterday { get; set; }

        public int? JanuaryOrderNum { get; set; }

        public int? FebruayOrderNum { get; set; }

        public int? MarchOrderNum { get; set; }

        public int? AprilOrderNum { get; set; }

        public int? MayOrderNum { get; set; }

        public int? JuneOrderNum { get; set; }

        public int? JulyOrderNum { get; set; }

        public int? AugustOrderNum { get; set; }

        public int? SeptemberOrderNum { get; set; }

        public int? OctoberOrderNum { get; set; }

        public int? NovemberOrderNum { get; set; }

        public int? DecemberOrderNum { get; set; }

        public int? StoreNum { get; set; }

        [StringLength(300)]
        public string CompanyName { get; set; }

        [StringLength(300)]
        public string ContractMoney { get; set; }

        [StringLength(300)]
        public string ContractRemark { get; set; }

        [StringLength(300)]
        public string ContractNum { get; set; }

        [StringLength(300)]
        public string CityName { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(10)]
        public string Contacts { get; set; }

        [StringLength(14)]
        public string ContactsPhone { get; set; }

        public int? ThreeDaysAgo { get; set; }
    }
}
