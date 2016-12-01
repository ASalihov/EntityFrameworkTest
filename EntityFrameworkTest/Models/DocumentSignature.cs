namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentSignature")]
    public partial class DocumentSignature
    {
        public int ID { get; set; }

        public int DocumentID { get; set; }

        [StringLength(300)]
        public string HashCode { get; set; }

        [Column(TypeName = "text")]
        public string SignedContent { get; set; }

        public DateTime? SignedDate { get; set; }

        [StringLength(50)]
        public string SignerSN { get; set; }

        public int? CompanyID { get; set; }

        public int? UserID { get; set; }

        public virtual Company Company { get; set; }

        public virtual Document Document { get; set; }

        public virtual User User { get; set; }
    }
}
