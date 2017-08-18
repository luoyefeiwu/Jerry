namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantRFMClassification")]
    public partial class RestaurantRFMClassification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantRFMClassification()
        {
            Customers = new HashSet<Customer>();
            Orders = new HashSet<Order>();
            RestaurantCustomerAutomaticClassifications = new HashSet<RestaurantCustomerAutomaticClassification>();
            RestaurantRFMs = new HashSet<RestaurantRFM>();
        }

        public int RestaurantRFMClassificationId { get; set; }

        [Required]
        [StringLength(10)]
        public string RestaurantRFMClassificationName { get; set; }

        public int ParentId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }

        public int BeginDay { get; set; }

        public int EndDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantCustomerAutomaticClassification> RestaurantCustomerAutomaticClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantRFM> RestaurantRFMs { get; set; }
    }
}
