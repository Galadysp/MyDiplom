namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Majors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Majors()
        {
            EmployeesEducation = new HashSet<EmployeesEducation>();
        }

        [Key]
        public int ID_Major { get; set; }

        [Required]
        [StringLength(250)]
        public string Name_Major { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeesEducation> EmployeesEducation { get; set; }
    }
}
