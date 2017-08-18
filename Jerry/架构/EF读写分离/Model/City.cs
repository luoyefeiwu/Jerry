namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public City()
        {
            AgentCommissionRatios = new HashSet<AgentCommissionRatio>();
            AgentInCities = new HashSet<AgentInCity>();
            CityBusinessDistricts = new HashSet<CityBusinessDistrict>();
            CityLandMarks = new HashSet<CityLandMark>();
            CityOrderBrokerages = new HashSet<CityOrderBrokerage>();
            t_Charge_Info = new HashSet<t_Charge_Info>();
        }

        public int CityID { get; set; }

        [Required]
        [StringLength(50)]
        public string CityName { get; set; }

        public int ParentID { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }

        public bool FreezeFlag { get; set; }

        public bool UseFlag { get; set; }

        public int Sequence { get; set; }

        public int MunicipalityFlag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentCommissionRatio> AgentCommissionRatios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentInCity> AgentInCities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityBusinessDistrict> CityBusinessDistricts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityLandMark> CityLandMarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityOrderBrokerage> CityOrderBrokerages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Charge_Info> t_Charge_Info { get; set; }
    }
}
