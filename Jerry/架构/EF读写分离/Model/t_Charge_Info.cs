namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_Charge_Info
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityID { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AgentId { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ChargeItem { get; set; }

        public int ChargeType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FeeA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal FeeB { get; set; }

        public int IsStop { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? CreateUserGuid { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? UpdateTime { get; set; }

        public Guid? UpdateUserGuid { get; set; }

        [StringLength(50)]
        public string UpdateUserName { get; set; }

        public virtual City City { get; set; }

        public virtual Product Product { get; set; }
    }
}
