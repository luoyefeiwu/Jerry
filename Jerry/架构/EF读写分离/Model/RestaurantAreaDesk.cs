namespace EF读写分离.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantAreaDesk")]
    public partial class RestaurantAreaDesk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantAreaDesk()
        {
            OrderDesks = new HashSet<OrderDesk>();
            RestaurantAreaDeskInRestaurantAreaDeskCosts = new HashSet<RestaurantAreaDeskInRestaurantAreaDeskCost>();
            RestaurantAreaDeskFacilities = new HashSet<RestaurantAreaDeskFacility>();
        }

        [Key]
        public Guid DeskGuid { get; set; }

        public Guid AreaGuid { get; set; }

        public Guid RestaurantGuid { get; set; }

        [Required]
        [StringLength(30)]
        public string DeskName { get; set; }

        public int PeopleMin { get; set; }

        public int PeopleMax { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public bool FreezeFlag { get; set; }

        public int sequence { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime CreateTime { get; set; }

        public decimal Balance { get; set; }

        public Guid RestaurantAreaDeskClassificationID { get; set; }

        public bool ReservationFlag { get; set; }

        [StringLength(200)]
        public string RoomFees { get; set; }

        public bool BesideTheWindowFlag { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; }

        public bool OpenNetReserve { get; set; }

        [StringLength(500)]
        public string OriginalImageUrl { get; set; }

        public string CustomerClassifications { get; set; }

        public string Sales { get; set; }

        public Guid? RestaurantUserGuid { get; set; }

        public bool OnlineBooking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDesk> OrderDesks { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual RestaurantArea RestaurantArea { get; set; }

        public virtual RestaurantAreaDeskClassification RestaurantAreaDeskClassification { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantAreaDeskInRestaurantAreaDeskCost> RestaurantAreaDeskInRestaurantAreaDeskCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantAreaDeskFacility> RestaurantAreaDeskFacilities { get; set; }
    }
}
