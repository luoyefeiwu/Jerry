namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerNote")]
    public partial class CustomerNote
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Month { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Day { get; set; }

        public DateTime CreateTime { get; set; }

        public bool OldLockFlag { get; set; }

        public Guid OldRfmGuid { get; set; }

        public Guid OldCustomerClassificationGuid { get; set; }

        public bool NewLockFlag { get; set; }

        public Guid NewRfmGuid { get; set; }

        public Guid NewCustomerClassificationGuid { get; set; }

        public int OldRFMClassifiyId { get; set; }

        public int OldRFMClassifiyIdSubclass { get; set; }

        public int NewRFMClassifiyId { get; set; }

        public int NewRFMClassifiyIdSubclass { get; set; }

        public bool CalculateFlag { get; set; }

        public DateTime? Lastmeal { get; set; }
    }
}
