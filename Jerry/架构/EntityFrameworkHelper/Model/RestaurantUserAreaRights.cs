namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RestaurantUserAreaRights
    {
        [Key]
        public int RestaurantUserAreaRightID { get; set; }

        public Guid RestaurantUserAreaGuid { get; set; }

        public Guid RestaurantUserGuid { get; set; }

        public DateTime Createtime { get; set; }

        public Guid Creator { get; set; }

        public DateTime Updatetime { get; set; }

        public Guid Updator { get; set; }

        public int Status { get; set; }
    }
}
