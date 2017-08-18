namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerTag")]
    public partial class CustomerTag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerTag()
        {
            CustomerTagClickLogs = new HashSet<CustomerTagClickLog>();
        }

        [Key]
        public Guid TagGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string TagName { get; set; }

        public Guid CustomerGuid { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Classifiy { get; set; }

        public int ClickNum { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerTagClickLog> CustomerTagClickLogs { get; set; }
    }
}
