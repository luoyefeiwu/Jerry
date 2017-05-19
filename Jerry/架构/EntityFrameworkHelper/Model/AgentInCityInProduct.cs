namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgentInCityInProduct")]
    public partial class AgentInCityInProduct
    {
        [Key]
        [Column(Order = 0)]
        public Guid AgentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string KeyWord { get; set; }

        [Required]
        [StringLength(50)]
        public string Value { get; set; }
    }
}
