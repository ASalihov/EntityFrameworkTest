namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentFile")]
    public partial class PaymentFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentFile()
        {
            PaymentFileItems = new HashSet<PaymentFileItem>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string FileName { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentFileItem> PaymentFileItems { get; set; }
    }
}
