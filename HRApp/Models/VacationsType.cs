namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VacationsType")]
    public partial class VacationsType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VacationsType()
        {
            EmployeesVacations = new HashSet<EmployeesVacations>();
        }

        [Key]
        public int ID_VacationType { get; set; }

        [StringLength(50)]
        public string Name_VacationType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeesVacations> EmployeesVacations { get; set; }
    }
}
