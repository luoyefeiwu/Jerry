namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReserveOrder")]
    public partial class ReserveOrder
    {
        public Guid ReserveOrderId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid CustomerGuid { get; set; }

        public DateTime MealDate { get; set; }

        [StringLength(400)]
        public string Remark { get; set; }

        public Guid RestaurantMealsTimeGuid { get; set; }

        public Guid RestaurantMealsTimeClassificationID { get; set; }

        public int ReserveNumber { get; set; }

        public int People { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerPhoneNumber { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerUnit { get; set; }

        public bool CustomerGender { get; set; }

        public Guid? CustomerClassificationGuid { get; set; }

        public Guid RFM { get; set; }

        public int RFMClassifiyId { get; set; }

        public int RFMSubClassifiyId { get; set; }

        public int Status { get; set; }

        public Guid CreatorId { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid UserSeviceGuid { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
