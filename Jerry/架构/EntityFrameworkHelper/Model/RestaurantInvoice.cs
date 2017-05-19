namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantInvoice")]
    public partial class RestaurantInvoice
    {
        [Key]
        public Guid InvoiceGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        public Guid RestaurantUserGuid { get; set; }

        public DateTime ApplyDate { get; set; }

        [Required]
        [StringLength(30)]
        public string InvoiceTitle { get; set; }

        public decimal InvoiceAmount { get; set; }

        [Required]
        [StringLength(10)]
        public string InvoiceReceiver { get; set; }

        [Required]
        [StringLength(30)]
        public string InvoiceReceiverPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceDeliveryAddress { get; set; }

        [StringLength(12)]
        public string invoiceDeliveryPost { get; set; }

        public int InvoiceType { get; set; }

        public int InvoiceStatus { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime? OpenInvoiceDate { get; set; }

        [StringLength(50)]
        public string InvoiceNumber { get; set; }

        public Guid? WhoOpenInvoice { get; set; }

        public int? ExpessType { get; set; }

        public DateTime? ExpessDate { get; set; }

        [StringLength(100)]
        public string ExpessNumber { get; set; }

        public Guid? WhoDelivery { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        [StringLength(200)]
        public string TaxpayerNumber { get; set; }

        [StringLength(1000)]
        public string OpenBank { get; set; }

        [StringLength(200)]
        public string AccountNumber { get; set; }

        [StringLength(500)]
        public string InvoiceAddress { get; set; }

        [StringLength(100)]
        public string InvoicePhone { get; set; }
    }
}
