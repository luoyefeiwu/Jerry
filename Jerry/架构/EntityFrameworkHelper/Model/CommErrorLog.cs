namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommErrorLog")]
    public partial class CommErrorLog
    {
        [Key]
        public Guid ErrorLogID { get; set; }

        [StringLength(200)]
        public string ProjectID { get; set; }

        [StringLength(200)]
        public string ModuleID { get; set; }

        [StringLength(500)]
        public string MachineName { get; set; }

        [StringLength(500)]
        public string MachineIp { get; set; }

        [StringLength(2000)]
        public string ProcessName { get; set; }

        [StringLength(2000)]
        public string ExpMessage { get; set; }

        [StringLength(2000)]
        public string ExpSource { get; set; }

        public string ExpStackTrace { get; set; }

        [StringLength(2000)]
        public string ExpTargetSite { get; set; }

        [StringLength(2000)]
        public string ExdMessage { get; set; }

        [StringLength(500)]
        public string ExdAssemblyName { get; set; }

        [StringLength(2000)]
        public string ExdClassName { get; set; }

        [StringLength(2000)]
        public string ExdMethodName { get; set; }

        [StringLength(2000)]
        public string ExdFileName { get; set; }

        public int? ExdLineNumber { get; set; }

        public string ExdStackTrace { get; set; }

        public string ExdUserData { get; set; }

        public DateTime ErrorDate { get; set; }

        public DateTime RecDate { get; set; }

        public int Status { get; set; }

        [StringLength(100)]
        public string UserID { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }
    }
}
