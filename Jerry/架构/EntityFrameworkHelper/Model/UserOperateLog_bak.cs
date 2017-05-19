namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserOperateLog_bak
    {
        [Key]
        [Column(Order = 0)]
        public long UserOperateLogId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid UserGuid { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PositionFlag { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperateType { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime OperateTime { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TargetType { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string TargetId { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }
    }
}
