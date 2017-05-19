namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentInCity")]
    public partial class AgentInCity
    {
        [Key]
        [Column(Order = 0)]
        public Guid AgentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityID { get; set; }

        public int ParentId { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual City City { get; set; }
    }
}
