namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerAliasClassification")]
    public partial class CustomerAliasClassification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerAliasClassification()
        {
            Customer = new HashSet<Customer>();
            CustomerAliasClassificationInRestaurantRFM = new HashSet<CustomerAliasClassificationInRestaurantRFM>();
        }

        [Key]
        public Guid CustomerClassificationGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerClassificationName { get; set; }

        public bool LockFlag { get; set; }

        public Guid RestaurantGuid { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool FreezeFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public int? Sequence { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customer { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAliasClassificationInRestaurantRFM> CustomerAliasClassificationInRestaurantRFM { get; set; }
    }
}
