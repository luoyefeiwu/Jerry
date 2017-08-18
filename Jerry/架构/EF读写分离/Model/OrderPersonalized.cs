namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderPersonalized")]
    public partial class OrderPersonalized
    {
        public int Id { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid CustomerGuid { get; set; }

        public Guid OrderGuid { get; set; }

        [Required]
        [StringLength(200)]
        public string Theme { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomNum { get; set; }

        [Required]
        [StringLength(40)]
        public string Sandtable { get; set; }

        [Required]
        [StringLength(40)]
        public string WelcomeScreen { get; set; }

        public int Way { get; set; }

        public int Status { get; set; }

        public Guid CreatorGuid { get; set; }

        public DateTime Createtime { get; set; }

        public Guid? UpdatorGuid { get; set; }

        public DateTime? Updatetime { get; set; }
    }
}
