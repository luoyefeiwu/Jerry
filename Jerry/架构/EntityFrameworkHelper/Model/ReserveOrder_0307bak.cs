namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReserveOrder_0307bak
    {
        [Key]
        [Column(Order = 0)]
        public Guid ReserveOrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid CustomerGuid { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime MealDate { get; set; }

        [StringLength(400)]
        public string Remark { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid RestaurantMealsTimeGuid { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid RestaurantMealsTimeClassificationID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReserveNumber { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int People { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string CustomerPhoneNumber { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerUnit { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool CustomerGender { get; set; }

        public Guid? CustomerClassificationGuid { get; set; }

        [Key]
        [Column(Order = 10)]
        public Guid RFM { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RFMClassifiyId { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RFMSubClassifiyId { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Key]
        [Column(Order = 14)]
        public Guid CreatorId { get; set; }

        [Key]
        [Column(Order = 15)]
        public DateTime CreateTime { get; set; }

        [Key]
        [Column(Order = 16)]
        public Guid UserSeviceGuid { get; set; }
    }
}
