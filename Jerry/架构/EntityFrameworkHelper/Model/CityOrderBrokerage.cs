namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CityOrderBrokerage")]
    public partial class CityOrderBrokerage
    {
        [Key]
        public int OrderBrokerageID { get; set; }

        public int CityID { get; set; }

        public decimal OrderBrokerage { get; set; }

        public virtual City City { get; set; }
    }
}
