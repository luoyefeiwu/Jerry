namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeiXin.WXMarkingSend")]
    public partial class WXMarkingSend
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WXMarkingSend()
        {
            WXBirthdayMarkingSend = new HashSet<WXBirthdayMarkingSend>();
        }

        public long WXMarkingSendId { get; set; }

        public Guid MarketingGuid { get; set; }

        public string OpenIds { get; set; }

        public int SendFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string Message { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WXBirthdayMarkingSend> WXBirthdayMarkingSend { get; set; }
    }
}
