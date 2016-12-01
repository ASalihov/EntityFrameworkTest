namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgreementVersion")]
    public partial class AgreementVersion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgreementVersion()
        {
            Companies = new HashSet<Company>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Version { get; set; }

        [Required]
        [StringLength(500)]
        public string FileName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }
    }
}
