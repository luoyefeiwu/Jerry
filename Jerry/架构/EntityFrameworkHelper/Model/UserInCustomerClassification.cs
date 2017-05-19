namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInCustomerClassification")]
    public partial class UserInCustomerClassification
    {
        [Key]
        [Column(Order = 0)]
        public Guid UserGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid CustomerClassificationGuid { get; set; }

        public Guid RestaurantGuid { get; set; }
    }
}
