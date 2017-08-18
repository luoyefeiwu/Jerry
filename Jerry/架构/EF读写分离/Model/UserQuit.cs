namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserQuit")]
    public partial class UserQuit
    {
        [Key]
        public Guid UserGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Position { get; set; }

        public string Phone { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime QuitTime { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
