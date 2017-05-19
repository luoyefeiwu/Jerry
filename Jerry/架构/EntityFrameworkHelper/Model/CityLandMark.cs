namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CityLandMark")]
    public partial class CityLandMark
    {
        [Key]
        public Guid LandMarkGuid { get; set; }

        [Required]
        [StringLength(20)]
        public string LandMarkName { get; set; }

        [StringLength(10)]
        public string X { get; set; }

        [StringLength(10)]
        public string Y { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public bool? FreezeFlag { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int CityID { get; set; }

        public Guid? AgentID { get; set; }

        public int Sequence { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual City City { get; set; }
    }
}
