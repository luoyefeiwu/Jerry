namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentCommissionRatio")]
    public partial class AgentCommissionRatio
    {
        public long AgentCommissionRatioId { get; set; }

        public Guid AgentId { get; set; }

        public int CityId { get; set; }

        public Guid ProductId { get; set; }

        public double Value { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual City City { get; set; }

        public virtual Product Product { get; set; }
    }
}
