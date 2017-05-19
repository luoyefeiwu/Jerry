namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerMultipleCount")]
    public partial class CustomerMultipleCount
    {
        [Key]
        public Guid CustomerGuid { get; set; }

        public DateTime CreateDate { get; set; }

        public int Type { get; set; }

        public Guid? Guid { get; set; }

        public int Number { get; set; }

        public decimal Amont { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
