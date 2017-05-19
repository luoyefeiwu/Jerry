namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_ActiveMemberValue
    {
        [Key]
        [Column(Order = 0)]
        public Guid RestaurantId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RFMGUID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RFMClassifiyIdSubclass { get; set; }

        public int CustomerNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OrderOfFrequency { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RecentDiningTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AverageSpend { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Expendamount { get; set; }

        [Required]
        [StringLength(20)]
        public string RFMName { get; set; }

        [Required]
        [StringLength(20)]
        public string RFMClassifiyName { get; set; }
    }
}
