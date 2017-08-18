namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInAgent")]
    public partial class UserInAgent
    {
        [Key]
        public Guid UserGuid { get; set; }

        public Guid AgentID { get; set; }

        public bool AdministratorFlag { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual User User { get; set; }
    }
}
