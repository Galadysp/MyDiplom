namespace HRApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FundingSources
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FundingSources()
        {
            BusinessTrips = new HashSet<BusinessTrips>();
        }

        [Key]
        public int ID_FundingSource { get; set; }

        [Required]
        [StringLength(50)]
        public string Name_FundingSource { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessTrips> BusinessTrips { get; set; }
    }
}
