namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DingZuoApp.TelOrder")]
    public partial class TelOrder
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string AppId { get; set; }

        [Required]
        [StringLength(50)]
        public string CallId { get; set; }

        [StringLength(50)]
        public string RequestId { get; set; }

        [Required]
        [StringLength(15)]
        public string Caller { get; set; }

        [Required]
        [StringLength(15)]
        public string Callee { get; set; }

        [Required]
        [StringLength(50)]
        public string DstVirtualNum { get; set; }

        public DateTime CallCenterAcceptTime { get; set; }

        public DateTime StartDstCallTime { get; set; }

        public DateTime? StartDstRingTime { get; set; }

        public DateTime DstAcceptTime { get; set; }

        public DateTime EndCallTime { get; set; }

        public int CallEndStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string CallerDuration { get; set; }

        [Required]
        [StringLength(50)]
        public string CalleeDuration { get; set; }

        [Required]
        [StringLength(50)]
        public string BindId { get; set; }

        [StringLength(50)]
        public string CalleeDisplayNum { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
