namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_BillNo
    {
        [Key]
        [Column(Order = 0)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string Bill_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Cur_No { get; set; }
    }
}
