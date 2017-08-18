namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DingZuoApp.DZFeedback")]
    public partial class DZFeedback
    {
        public long Id { get; set; }

        [StringLength(100)]
        public string OpenId { get; set; }

        public Guid? DZUID { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(1000)]
        public string Message { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
