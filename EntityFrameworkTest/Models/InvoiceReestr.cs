namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceReestr")]
    public partial class InvoiceReestr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceReestr()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        public DateTime AddedDate { get; set; }

        [StringLength(50)]
        public string OrginalFileName { get; set; }

        public int? CompanyID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
