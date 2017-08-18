namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderOtherPayRecord")]
    public partial class OrderOtherPayRecord
    {
        [Key]
        public Guid PayRecordGuid { get; set; }

        public Guid OrderGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public int PayType { get; set; }

        [StringLength(50)]
        public string PayTypeNote { get; set; }

        public decimal Money { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
