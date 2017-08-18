namespace EF读写分离.Model
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
            AgentCommissionRatios = new HashSet<AgentCommissionRatio>();
            AgentInCities = new HashSet<AgentInCity>();
            AgentInRestaurants = new HashSet<AgentInRestaurant>();
            AgentInRestaurantRejectedRecords = new HashSet<AgentInRestaurantRejectedRecord>();
            CityBusinessDistricts = new HashSet<CityBusinessDistrict>();
            CityLandMarks = new HashSet<CityLandMark>();
            Restaurants = new HashSet<Restaurant>();
            UserInAgents = new HashSet<UserInAgent>();
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
        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(100)]
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
        public virtual ICollection<AgentCommissionRatio> AgentCommissionRatios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInCity> AgentInCities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInRestaurant> AgentInRestaurants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInRestaurantRejectedRecord> AgentInRestaurantRejectedRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityBusinessDistrict> CityBusinessDistricts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityLandMark> CityLandMarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Restaurant> Restaurants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInAgent> UserInAgents { get; set; }
    }
}
