namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ImportDataTemp03131
    {
        [StringLength(500)]
        public string mealsDateStr { get; set; }

        [StringLength(500)]
        public string mealsTimeStr { get; set; }

        [StringLength(500)]
        public string mealsTimeClassName { get; set; }

        [StringLength(500)]
        public string deskName { get; set; }

        [StringLength(500)]
        public string orderPeople { get; set; }

        [StringLength(500)]
        public string customerName { get; set; }

        [StringLength(500)]
        public string customerSex { get; set; }

        [StringLength(500)]
        public string customerPhone { get; set; }

        [StringLength(500)]
        public string customerUnit { get; set; }

        [StringLength(1000)]
        public string orderNote { get; set; }

        [StringLength(500)]
        public string userName { get; set; }

        [StringLength(500)]
        public string money { get; set; }

        [StringLength(500)]
        public string orderStatus { get; set; }

        public Guid? ImportBatchID { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid RestaurantID { get; set; }

        [StringLength(500)]
        public string JointNumber { get; set; }

        public Guid? OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsPush { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreateTime { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid CreateUserId { get; set; }
    }
}
