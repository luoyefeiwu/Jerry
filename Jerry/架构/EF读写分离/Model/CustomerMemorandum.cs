namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerMemorandum")]
    public partial class CustomerMemorandum
    {
        [Key]
        public int MemorandumId { get; set; }

        public Guid CustomerId { get; set; }

        [Required]
        [StringLength(500)]
        public string ContentInfo { get; set; }

        public Guid OperatorGuid { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
