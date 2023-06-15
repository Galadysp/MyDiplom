namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeesEducation")]
    public partial class EmployeesEducation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Major { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Education_Level { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EducationPlace { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Employer { get; set; }

        public bool? WithHonors { get; set; }

        public virtual EducationLevels EducationLevels { get; set; }

        public virtual EducationPlaces EducationPlaces { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Majors Majors { get; set; }
    }
}
