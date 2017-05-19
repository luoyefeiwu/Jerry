namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            AgentCommissionRatio = new HashSet<AgentCommissionRatio>();
            AgentInCity = new HashSet<AgentInCity>();
            AgentInRestaurant = new HashSet<AgentInRestaurant>();
            AgentInRestaurantRejectedRecord = new HashSet<AgentInRestaurantRejectedRecord>();
            CityBusinessDistrict = new HashSet<CityBusinessDistrict>();
            CityLandMark = new HashSet<CityLandMark>();
            Restaurant = new HashSet<Restaurant>();
            UserInAgent = new HashSet<UserInAgent>();
        }

        public Guid AgentID { get; set; }

        [Required]
        [StringLength(60)]
        public string Tel { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool FreezeFlag { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string CompanyAddress { get; set; }

        [StringLength(12)]
        public string PostCode { get; set; }

        [StringLength(20)]
        public string OpeningAnAccountProvince { get; set; }

        [StringLength(20)]
        public string OpeningAnAccountCity { get; set; }

        [StringLength(30)]
        public string OpeningAnAccount { get; set; }

        [StringLength(30)]
        public string BankAccount { get; set; }

        [StringLength(10)]
        public string Payee { get; set; }

        public bool DirectLoginRestaurantFlag { get; set; }

        public decimal Amount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentCommissionRatio> AgentCommissionRatio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInCity> AgentInCity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInRestaurant> AgentInRestaurant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInRestaurantRejectedRecord> AgentInRestaurantRejectedRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityBusinessDistrict> CityBusinessDistrict { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityLandMark> CityLandMark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Restaurant> Restaurant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInAgent> UserInAgent { get; set; }
    }
}
