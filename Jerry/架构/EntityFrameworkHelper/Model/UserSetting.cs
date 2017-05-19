namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSetting")]
    public partial class UserSetting
    {
        [Key]
        public Guid UserId { get; set; }

        public int OccupyDeskSortType { get; set; }

        public bool LockCurOccupyMealTime { get; set; }

        public bool ShowOrdered { get; set; }

        public bool ShowGuest { get; set; }

        public bool ShowRevered { get; set; }

        public bool ShowSimpleModel { get; set; }

        public bool ShowPeople { get; set; }
    }
}
