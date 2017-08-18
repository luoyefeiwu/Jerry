namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarketingClassification")]
    public partial class MarketingClassification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarketingClassification()
        {
            MarketingCounts = new HashSet<MarketingCount>();
        }

        [Key]
        public Guid MarketingClassificationGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string MarketingClassificationName { get; set; }

        public bool CouponFlag { get; set; }

        public int Sequence { get; set; }

        public bool FreezeFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarketingCount> MarketingCounts { get; set; }
    }
}
