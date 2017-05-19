namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CityBusinessDistrict")]
    public partial class CityBusinessDistrict
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CityBusinessDistrict()
        {
            Restaurant = new HashSet<Restaurant>();
        }

        public Guid CityBusinessDistrictID { get; set; }

        [Required]
        [StringLength(20)]
        public string CityBusinessDistrictName { get; set; }

        [StringLength(10)]
        public string X { get; set; }

        [StringLength(10)]
        public string Y { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public bool FreezeFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int CityID { get; set; }

        public Guid? AgentID { get; set; }

        public int Sequence { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}
