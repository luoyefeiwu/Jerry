namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserOperateLog")]
    public partial class UserOperateLog
    {
        public long UserOperateLogId { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid UserGuid { get; set; }

        public int PositionFlag { get; set; }

        public int OperateType { get; set; }

        public DateTime OperateTime { get; set; }

        public int TargetType { get; set; }

        [Required]
        [StringLength(50)]
        public string TargetId { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }
    }
}
