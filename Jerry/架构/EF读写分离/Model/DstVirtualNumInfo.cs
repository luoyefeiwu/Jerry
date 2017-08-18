namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DingZuoApp.DstVirtualNumInfo")]
    public partial class DstVirtualNumInfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DstVirtualNum { get; set; }

        public Guid RestaurantId { get; set; }

        [Required]
        [StringLength(20)]
        public string CityId { get; set; }

        public bool Status { get; set; }

        public DateTime ModifyTime { get; set; }
    }
}
