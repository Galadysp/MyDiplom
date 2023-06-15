using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HRApp.Models
{
    public partial class HRAppModel2 : DbContext
    {
        public HRAppModel2()
            : base("name=HRAppModel2")
        {
        }

        public virtual DbSet<BusinessTrips> BusinessTrips { get; set; }
        public virtual DbSet<EducationLevels> EducationLevels { get; set; }
        public virtual DbSet<EducationPlaces> EducationPlaces { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeesVacations> EmployeesVacations { get; set; }
        public virtual DbSet<FundingSources> FundingSources { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Hours> Hours { get; set; }
        public virtual DbSet<Leaves> Leaves { get; set; }
        public virtual DbSet<Majors> Majors { get; set; }
        public virtual DbSet<MaritalStatuses> MaritalStatuses { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<ReasonsOfLeaving> ReasonsOfLeaving { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VacationsType> VacationsType { get; set; }
        public virtual DbSet<EmployeesEducation> EmployeesEducation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationLevels>()
                .HasMany(e => e.EmployeesEducation)
                .WithRequired(e => e.EducationLevels)
                .HasForeignKey(e => e.Education_Level)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EducationPlaces>()
                .HasMany(e => e.EmployeesEducation)
                .WithRequired(e => e.EducationPlaces)
                .HasForeignKey(e => e.EducationPlace)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PassportNum)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.PassportSer)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.INN)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.SNILS)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.BusinessTrips)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeesEducation)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.Employer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeesVacations)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Leaves)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FundingSources>()
                .HasMany(e => e.BusinessTrips)
                .WithOptional(e => e.FundingSources)
                .HasForeignKey(e => e.FundingSource);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Gender1)
                .IsFixedLength();

            modelBuilder.Entity<Gender>()
                .Property(e => e.GenderFull)
                .IsFixedLength();

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.Gender1)
                .HasForeignKey(e => e.Gender);

            modelBuilder.Entity<Hours>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Hours)
                .HasForeignKey(e => e.Hour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Majors>()
                .HasMany(e => e.EmployeesEducation)
                .WithRequired(e => e.Majors)
                .HasForeignKey(e => e.Major)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaritalStatuses>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.MaritalStatuses)
                .HasForeignKey(e => e.MaritalStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Positions>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Positions)
                .HasForeignKey(e => e.Position)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReasonsOfLeaving>()
                .HasMany(e => e.Leaves)
                .WithOptional(e => e.ReasonsOfLeaving)
                .HasForeignKey(e => e.Reason);

            modelBuilder.Entity<States>()
                .HasMany(e => e.EducationPlaces)
                .WithRequired(e => e.States)
                .HasForeignKey(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<States>()
                .HasMany(e => e.Employee)
                .WithOptional(e => e.States)
                .HasForeignKey(e => e.PlaceOfBirth);

            modelBuilder.Entity<VacationsType>()
                .HasMany(e => e.EmployeesVacations)
                .WithOptional(e => e.VacationsType)
                .HasForeignKey(e => e.VacationType);
        }
    }
}
