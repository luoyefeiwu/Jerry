namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deskcommission")]
    public partial class Deskcommission
    {
        [Key]
        [Column(Order = 0)]
        public Guid OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid DeskID { get; set; }

        [Required]
        [StringLength(30)]
        public string DeskName { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string RestaurantName { get; set; }

        public Guid UserSeviceGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string UserSeviceName { get; set; }

        public Guid CustomerGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        public int Money { get; set; }

        public int Status { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
