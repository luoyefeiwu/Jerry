namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantProduct")]
    public partial class RestaurantProduct
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Mid { get; set; }

        public Guid RestaurantID { get; set; }

        public Guid ProductID { get; set; }

        public decimal BuyPrice { get; set; }

        public int ChargeType { get; set; }

        public decimal SiteProfitMoney { get; set; }

        public decimal AgientProfitMoney { get; set; }

        public decimal ROP { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public Guid UserId { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        public DateTime BuyTime { get; set; }

        public Guid AgentId { get; set; }

        public bool InUseFlag { get; set; }

        public virtual Product Product { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
