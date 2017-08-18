namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuthTokenControlCenter")]
    public partial class AuthTokenControlCenter
    {
        [Key]
        public long ATCCID { get; set; }

        [Required]
        [StringLength(128)]
        public string Appid { get; set; }

        [StringLength(128)]
        public string Secretid { get; set; }

        public int? TokenType { get; set; }

        [Required]
        [StringLength(1024)]
        public string Token { get; set; }

        public DateTime TokenExpires { get; set; }

        [StringLength(1024)]
        public string RefreshToken { get; set; }

        public DateTime? RefreshTokenExpires { get; set; }
    }
}
