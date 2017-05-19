namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductCommissionRatio")]
    public partial class ProductCommissionRatio
    {
        public long ProductCommissionRatioId { get; set; }

        public Guid ProductID { get; set; }

        public int CityId { get; set; }

        public int CommissionType { get; set; }

        public virtual Product Product { get; set; }
    }
}
