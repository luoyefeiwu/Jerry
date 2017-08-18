namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SmsPrice")]
    public partial class SmsPrice
    {
        public long SmsPriceId { get; set; }

        public int CityId { get; set; }

        public int SmsType { get; set; }

        public double Value { get; set; }
    }
}
