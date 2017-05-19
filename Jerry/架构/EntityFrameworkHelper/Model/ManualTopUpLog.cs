namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManualTopUpLog")]
    public partial class ManualTopUpLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public Guid UserId { get; set; }

        [StringLength(200)]
        public string ReceivingBank { get; set; }

        [StringLength(100)]
        public string Payee { get; set; }

        public decimal AmountCollected { get; set; }

        public DateTime CollectionDate { get; set; }

        public Guid MoneyInstitutionsId { get; set; }

        [Required]
        [StringLength(100)]
        public string MoneyInstitutionsName { get; set; }

        [StringLength(100)]
        public string PlayWithPeople { get; set; }

        [StringLength(100)]
        public string PersonHandlingIt { get; set; }

        [StringLength(200)]
        public string TheCredentialsToUpload { get; set; }

        public int ManualTopUpType { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
