namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DingZuoApp.DZUserOrder")]
    public partial class DZUserOrder
    {
        [Key]
        [Column(Order = 0)]
        public Guid DZUID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string AccountTel { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid RestaurantId { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreateTime { get; set; }
    }
}
