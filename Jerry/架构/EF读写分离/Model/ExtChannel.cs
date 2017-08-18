namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtChannel")]
    public partial class ExtChannel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExtChannel()
        {
            ExtChannelPhones = new HashSet<ExtChannelPhone>();
            ExtChannelCities = new HashSet<ExtChannelCity>();
        }

        [Key]
        public Guid ExternalChannelId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int ChannelType { get; set; }

        [Required]
        [StringLength(100)]
        public string Logo { get; set; }

        public DateTime CreateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtChannelPhone> ExtChannelPhones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtChannelCity> ExtChannelCities { get; set; }
    }
}
