namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Leaves
    {
        [Key]
        public int ID_leave { get; set; }

        public int? Reason { get; set; }

        public int ID_Employer { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfLeaving { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ReasonsOfLeaving ReasonsOfLeaving { get; set; }
    }
}
