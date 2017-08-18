namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerSurveyClassification")]
    public partial class CustomerSurveyClassification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerSurveyClassification()
        {
            CustomerSurveys = new HashSet<CustomerSurvey>();
            CustomerSurveyClassification1 = new HashSet<CustomerSurveyClassification>();
        }

        [Key]
        public Guid CustomerSurveyClassificationGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerSurveyClassificationName { get; set; }

        public Guid? ParentGuid { get; set; }

        public Guid? RestaurantGuid { get; set; }

        public int Sequence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSurvey> CustomerSurveys { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSurveyClassification> CustomerSurveyClassification1 { get; set; }

        public virtual CustomerSurveyClassification CustomerSurveyClassification2 { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
