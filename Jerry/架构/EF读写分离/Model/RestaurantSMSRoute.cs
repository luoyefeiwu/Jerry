namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantSMSRoute")]
    public partial class RestaurantSMSRoute
    {
        [Key]
        public int routeId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [StringLength(50)]
        public string SMSAccountID { get; set; }

        [StringLength(150)]
        public string Secret { get; set; }

        [Required]
        [StringLength(50)]
        public string SMSRoute { get; set; }

        [Required]
        [StringLength(20)]
        public string SMSRouteSign { get; set; }

        public bool Status { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Creater { get; set; }
    }
}
