namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SmsTemplateParameter")]
    public partial class SmsTemplateParameter
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool FreeFlag { get; set; }

        public int Sequence { get; set; }
    }
}
