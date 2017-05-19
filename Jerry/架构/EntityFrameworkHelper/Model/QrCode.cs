namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.QrCode")]
    public partial class QrCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QrCode()
        {
            QrCodeLog = new HashSet<QrCodeLog>();
            QrCodeStat = new HashSet<QrCodeStat>();
        }

        public long QrCodeId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid CreatorId { get; set; }

        public Guid ModifierId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int SceneId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDefault { get; set; }

        [StringLength(50)]
        public string FilePath { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QrCodeLog> QrCodeLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QrCodeStat> QrCodeStat { get; set; }
    }
}
