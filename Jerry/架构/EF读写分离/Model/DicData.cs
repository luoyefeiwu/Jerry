namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DicData")]
    public partial class DicData
    {
        public int Id { get; set; }

        public int Type { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
