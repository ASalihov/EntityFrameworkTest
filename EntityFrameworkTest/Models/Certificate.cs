namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Certificate")]
    public partial class Certificate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Certificate()
        {
            Companies = new HashSet<Company>();
            Users = new HashSet<User>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        [StringLength(50)]
        public string Organisation { get; set; }

        [StringLength(50)]
        public string ValidTo { get; set; }

        [StringLength(50)]
        public string Inn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
