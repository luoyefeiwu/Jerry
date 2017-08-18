namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerDisease")]
    public partial class CustomerDisease
    {
        [Key]
        [Column(Order = 0)]
        public Guid CustomerID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid DiseaseID { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreateTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime UpdateTime { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Disease Disease { get; set; }
    }
}
