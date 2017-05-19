namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentChainCheckMsg")]
    public partial class AgentChainCheckMsg
    {
        public int Id { get; set; }

        public Guid AgentId { get; set; }

        public Guid ChainId { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string RestaurantName { get; set; }

        public int SpFlag { get; set; }

        [StringLength(200)]
        public string SpMemo { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
