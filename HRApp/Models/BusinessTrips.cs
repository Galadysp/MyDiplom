namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusinessTrips
    {
        [Key]
        public int ID_BusinessTrips { get; set; }

        public int ID_Employer { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfReturning { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfLeaving { get; set; }

        [Required]
        [StringLength(150)]
        public string ReasonOfBusinessTrip { get; set; }

        public int? FundingSource { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfTheOrder { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual FundingSources FundingSources { get; set; }
    }
}
