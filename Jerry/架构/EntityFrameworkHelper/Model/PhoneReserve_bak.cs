namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PhoneReserve_bak
    {
        [Key]
        [Column(Order = 0)]
        public Guid PhoneReserveId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Number { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid CreatorId { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid OperatorId { get; set; }

        public Guid? OrderGuid { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CreateTime { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Missed { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }
    }
}
