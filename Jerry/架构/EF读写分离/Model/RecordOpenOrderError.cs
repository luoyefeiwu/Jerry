namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecordOpenOrderError")]
    public partial class RecordOpenOrderError
    {
        public int Id { get; set; }

        public Guid? UserId { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        public int OperationType { get; set; }

        public DateTime OperationDateTime { get; set; }

        public Guid DeskId { get; set; }

        [StringLength(500)]
        public string DeskName { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        [StringLength(1000)]
        public string ErrorMessage { get; set; }

        public Guid? OrderId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(100)]
        public string Mealtime { get; set; }

        public Guid PeriodId { get; set; }

        [Required]
        [StringLength(100)]
        public string PeriodName { get; set; }

        public bool IsMultiTable { get; set; }
    }
}
