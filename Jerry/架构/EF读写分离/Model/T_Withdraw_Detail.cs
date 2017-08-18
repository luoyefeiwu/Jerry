namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Withdraw_Detail
    {
        public Guid WithdrawUintGuid { get; set; }

        [StringLength(50)]
        public string WithdrawUintName { get; set; }

        public DateTime BillDate { get; set; }

        public int type { get; set; }

        public Guid CreateUserGuid { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public int BillStatus { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Money { get; set; }

        [StringLength(100)]
        public string WithdrawBankAccount { get; set; }

        [StringLength(100)]
        public string WithdrawOpeningBank { get; set; }

        [StringLength(100)]
        public string WithdrawBankBranchAddress { get; set; }

        [StringLength(100)]
        public string BankBillNo { get; set; }

        [Key]
        public long WithdrawNo { get; set; }
    }
}
