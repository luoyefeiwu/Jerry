namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stat_ChannelResource_Total
    {
        [Key]
        public Guid ResourceOwnerId { get; set; }

        public int resourcenum { get; set; }

        public DateTime createtime { get; set; }

        public DateTime updatetime { get; set; }
    }
}
