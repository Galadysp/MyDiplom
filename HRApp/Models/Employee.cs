namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            BusinessTrips = new HashSet<BusinessTrips>();
            EmployeesEducation = new HashSet<EmployeesEducation>();
            EmployeesVacations = new HashSet<EmployeesVacations>();
            Leaves = new HashSet<Leaves>();
        }

        [Key]
        public int ID_Employer { get; set; }

        [Required]
        [StringLength(50)]
        public string F_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string S_Name { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        public int Position { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfEmployment { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        public int Hour { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [StringLength(250)]
        public string Adress { get; set; }

        public bool? IsWorker { get; set; }

        public bool IsRetiree { get; set; }

        [StringLength(6)]
        public string PassportNum { get; set; }

        [StringLength(4)]
        public string PassportSer { get; set; }

        [StringLength(12)]
        public string INN { get; set; }

        [StringLength(11)]
        public string SNILS { get; set; }

        public int MaritalStatus { get; set; }

        public int? PlaceOfBirth { get; set; }

        [StringLength(1000)]
        public string ProfilePicture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessTrips> BusinessTrips { get; set; }

        public virtual Gender Gender1 { get; set; }

        public virtual Hours Hours { get; set; }

        public virtual MaritalStatuses MaritalStatuses { get; set; }

        public virtual Positions Positions { get; set; }

        public virtual States States { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeesEducation> EmployeesEducation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeesVacations> EmployeesVacations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leaves> Leaves { get; set; }
    }
}
