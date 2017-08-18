namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerClassWithRFM")]
    public partial class CustomerClassWithRFM
    {
        [Key]
        public Guid CustomerClassificationRFId { get; set; }

        public Guid CustomerClassificationGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public bool HighvalueImportant { get; set; }

        public bool HighvalueCommon { get; set; }

        public bool DevelopImportant { get; set; }

        public bool DevelopCommon { get; set; }

        public bool NeedkeepImportant { get; set; }

        public bool NeedkeepCommon { get; set; }

        public bool ToretainImportant { get; set; }

        public bool ToretainCommon { get; set; }

        public DateTime Createtime { get; set; }

        public DateTime Updatetime { get; set; }

        public Guid OperaterId { get; set; }
    }
}
