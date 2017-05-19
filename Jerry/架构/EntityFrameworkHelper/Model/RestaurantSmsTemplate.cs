namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantSmsTemplate")]
    public partial class RestaurantSmsTemplate
    {
        [Key]
        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(400)]
        public string BaseInfoTemplate { get; set; }

        [Required]
        [StringLength(400)]
        public string UserServiceTemplate { get; set; }

        public string MessagePreview { get; set; }

        public Guid? ModifiyUserId { get; set; }

        public DateTime ModifiyTime { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
