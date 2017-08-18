namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantRFM")]
    public partial class RestaurantRFM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantRFM()
        {
            CustomerAliasClassificationInRestaurantRFMs = new HashSet<CustomerAliasClassificationInRestaurantRFM>();
            Orders = new HashSet<Order>();
        }

        [Key]
        public Guid RFMGuid { get; set; }

        [Required]
        [StringLength(8)]
        public string RFMName { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Sequencing { get; set; }

        public int RestaurantRFMClassificationId { get; set; }

        public int AveragespendFlag { get; set; }

        public int ExpendamountFlag { get; set; }

        public int OrderOfFrequencyFlag { get; set; }

        public int RecentDiningTimeFlag { get; set; }

        public bool AmountOfComputationFlag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAliasClassificationInRestaurantRFM> CustomerAliasClassificationInRestaurantRFMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        public virtual RestaurantRFMClassification RestaurantRFMClassification { get; set; }
    }
}
