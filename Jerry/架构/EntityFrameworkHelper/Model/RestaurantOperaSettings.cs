namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RestaurantOperaSettings
    {
        [Key]
        public Guid RestaurantOperaSettingID { get; set; }

        [Required]
        [StringLength(50)]
        public string OperaCode { get; set; }

        public int OperaType { get; set; }

        public int OperaStatus { get; set; }

        public bool Status { get; set; }
    }
}
