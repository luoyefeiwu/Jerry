namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnalysisBusinessTemporaryTask")]
    public partial class AnalysisBusinessTemporaryTask
    {
        public Guid AnalysisBusinessTemporaryTaskId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public int Status { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskNum { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
