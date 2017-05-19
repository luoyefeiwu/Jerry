namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLoginLog")]
    public partial class UserLoginLog
    {
        public long UserLoginLogId { get; set; }

        public Guid UserGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual User User { get; set; }
    }
}
