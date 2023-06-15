namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EducationPlaces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EducationPlaces()
        {
            EmployeesEducation = new HashSet<EmployeesEducation>();
        }

        [Key]
        public int ID_EducationPlace { get; set; }

        [Required]
        [StringLength(50)]
        public string Name_EducationPlace { get; set; }

        public int State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeesEducation> EmployeesEducation { get; set; }

        public virtual States States { get; set; }
    }
}
