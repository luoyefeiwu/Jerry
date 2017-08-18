namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaDeskInRestaurantAreaDeskCost")]
    public partial class RestaurantAreaDeskInRestaurantAreaDeskCost
    {
        [Key]
        [Column(Order = 0)]
        public Guid DeskGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantAreaDeskCostID { get; set; }

        public decimal Balance { get; set; }

        public virtual RestaurantAreaDesk RestaurantAreaDesk { get; set; }

        public virtual RestaurantAreaDeskCost RestaurantAreaDeskCost { get; set; }
    }
}
