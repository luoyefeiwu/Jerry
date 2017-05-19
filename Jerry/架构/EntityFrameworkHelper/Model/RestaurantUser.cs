namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantUser")]
    public partial class RestaurantUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantUser()
        {
            RestaurantUser1 = new HashSet<RestaurantUser>();
        }

        [Key]
        public Guid RestaurantUserGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid? UserParentGuid { get; set; }

        public int GroupType { get; set; }

        public Guid UserSourceId { get; set; }

        public bool DailyFlag { get; set; }

        public bool OrdertoInformFlag { get; set; }

        public bool OpenSale { get; set; }

        public double? signingdiscount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CooperationBegin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CooperationEnd { get; set; }

        public int? CommissionType { get; set; }

        public double? CommissionValue { get; set; }

        public double? NewCustomerCommission { get; set; }

        public int ReceiveResourceNum { get; set; }

        public int SelfOpenNum { get; set; }

        public int OtherOpenNum { get; set; }

        public int OpenOtherNum { get; set; }

        public int AssignResourceNum { get; set; }

        public int Status { get; set; }

        public bool ManageAllUser { get; set; }

        public bool ManageAllDesk { get; set; }

        public bool ProtectPhone { get; set; }

        public bool IsSmsIncludeUserInfo { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantUser> RestaurantUser1 { get; set; }

        public virtual RestaurantUser RestaurantUser2 { get; set; }
    }
}
