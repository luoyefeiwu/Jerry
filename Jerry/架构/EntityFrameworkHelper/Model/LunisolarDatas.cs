namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chinese.LunisolarDatas")]
    public partial class LunisolarDatas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int yearId { get; set; }

        [StringLength(7)]
        public string data { get; set; }

        public int? dataInt { get; set; }

        [StringLength(7)]
        public string Data1 { get; set; }

        public int? DataInt1 { get; set; }
    }
}
