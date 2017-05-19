namespace EntityFrameworkHelper.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            CustomerTagClickLog = new HashSet<CustomerTagClickLog>();
            RestaurantMealsTime = new HashSet<RestaurantMealsTime>();
            UserLoginLog = new HashSet<UserLoginLog>();
            UserPhone = new HashSet<UserPhone>();
            Application = new HashSet<Application>();
        }

        [Key]
        public Guid UserGuid { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool Gender { get; set; }

        [StringLength(20)]
        public string WorkPhone { get; set; }

        [StringLength(30)]
        public string Position { get; set; }

        public bool LoginFlag { get; set; }

        public bool FreezeFlag { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(120)]
        public string Logo { get; set; }

        public int? SystemGenerate { get; set; }

        [StringLength(50)]
        public string RestaurantName { get; set; }

        [Column(TypeName = "ntext")]
        public string Introduce { get; set; }

        public virtual AdminManageUser AdminManageUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerTagClickLog> CustomerTagClickLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMealsTime> RestaurantMealsTime { get; set; }

        public virtual UserInAgent UserInAgent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLoginLog> UserLoginLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPhone> UserPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
    }
}
