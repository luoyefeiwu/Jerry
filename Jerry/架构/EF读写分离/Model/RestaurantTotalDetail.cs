namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantTotalDetail")]
    public partial class RestaurantTotalDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatYear { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatMonth { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatDay { get; set; }

        public int EffectiveRestaurantNum { get; set; }

        public int RestaurantStartUpNum { get; set; }

        public int RestaurantLoginNum { get; set; }

        public int SaleNum { get; set; }

        public int SaleAppOrderNum { get; set; }
    }
}
