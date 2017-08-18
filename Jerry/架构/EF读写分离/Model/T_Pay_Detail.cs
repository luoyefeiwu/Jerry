namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Pay_Detail
    {
        public Guid RestaurantGuid { get; set; }

        [StringLength(50)]
        public string RestaurantName { get; set; }

        public DateTime BillDate { get; set; }

        public int type { get; set; }

        public Guid CreateUserGuid { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public int BillStatus { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Money { get; set; }

        [StringLength(100)]
        public string InComeBankAccount { get; set; }

        [StringLength(100)]
        public string InComeOpeningBank { get; set; }

        [StringLength(100)]
        public string InComeBankBranchAddress { get; set; }

        [StringLength(100)]
        public string PayBankAccount { get; set; }

        [StringLength(100)]
        public string PayOpeningBank { get; set; }

        [StringLength(100)]
        public string PayBankBranchAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string PayRestaurantName { get; set; }

        [Required]
        [StringLength(100)]
        public string PayRestaurantGuid { get; set; }

        [StringLength(100)]
        public string BankBillNo { get; set; }

        public int? CorpType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BeforeTheFinancial { get; set; }

        [Key]
        public long PayNo { get; set; }
    }
}
