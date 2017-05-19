namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderInMarketing")]
    public partial class OrderInMarketing
    {
        [Key]
        [Column(Order = 0)]
        public Guid OrderGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MarketingGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid DeskID { get; set; }

        public Guid? CustomerGuid { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public virtual Marketing Marketing { get; set; }

        public virtual Order Order { get; set; }
    }
}
