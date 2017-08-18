namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsTask
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AgentID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid RestaurantGuid { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid MarketingGuid { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid ParentGuid { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SmsType { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(1024)]
        public string SmsContent { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CreateTime { get; set; }

        public int? erritem { get; set; }

        [StringLength(1024)]
        public string SmsErrorMsg { get; set; }
    }
}
