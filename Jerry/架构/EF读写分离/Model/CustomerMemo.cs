namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerMemo")]
    public partial class CustomerMemo
    {
        public long CustomerMemoId { get; set; }

        public Guid UserId { get; set; }

        public Guid CustomerId { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid? Creator { get; set; }
    }
}
