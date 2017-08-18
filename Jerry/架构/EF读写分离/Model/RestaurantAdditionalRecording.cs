namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAdditionalRecording")]
    public partial class RestaurantAdditionalRecording
    {
        [Key]
        [Column(Order = 0)]
        public Guid OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RestaurantId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime MealtimeDay { get; set; }

        public bool OverFlag { get; set; }

        public Guid? CustomerId { get; set; }
    }
}
