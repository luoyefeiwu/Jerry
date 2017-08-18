namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerSurvey")]
    public partial class CustomerSurvey
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerSurveyClassificationGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CustomerGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreateDate { get; set; }

        public DateTime SurveyTime { get; set; }

        public Guid RestaurantMealsTimeId { get; set; }

        public Guid RestaurantMealsTimeClassificationId { get; set; }

        public Guid ParentCustomerSurveyClassificationGuid { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual CustomerSurveyClassification CustomerSurveyClassification { get; set; }
    }
}
