namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeesVacations
    {
        [Key]
        public int ID_Vacation { get; set; }

        public int ID_Employer { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfTheOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfReturning { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfLeaving { get; set; }

        public int? VacationType { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual VacationsType VacationsType { get; set; }
    }
}
