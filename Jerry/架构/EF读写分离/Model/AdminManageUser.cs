namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminManageUser")]
    public partial class AdminManageUser
    {
        [Key]
        public Guid UserGuid { get; set; }

        public bool IsAdmin { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public virtual User User { get; set; }
    }
}
