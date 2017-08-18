namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentReasonForRejection")]
    public partial class AgentReasonForRejection
    {
        public int AgentReasonForRejectionID { get; set; }

        [Required]
        [StringLength(254)]
        public string AgentReasonForRejectionContent { get; set; }
    }
}
