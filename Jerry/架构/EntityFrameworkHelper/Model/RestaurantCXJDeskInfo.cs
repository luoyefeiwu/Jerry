namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantCXJDeskInfo")]
    public partial class RestaurantCXJDeskInfo
    {
        [Key]
        public int KBDCXJ_DeskId { get; set; }

        public Guid? KBD_DeskId { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string AreaName { get; set; }

        public int? Type { get; set; }

        public int People { get; set; }

        public int IsUpdated { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(50)]
        public string CXJ_DeskId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int? Parent_KBDCXJ_DeskId { get; set; }
    }
}
