namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentAgreementUser")]
    public partial class DocumentAgreementUser
    {
        public int ID { get; set; }

        public int DocumentID { get; set; }

        public int UserID { get; set; }

        public bool? Agree { get; set; }

        public DateTime? AgreementDate { get; set; }

        [StringLength(1000)]
        public string Comment { get; set; }

        public int ProccessType { get; set; }

        public virtual Document Document { get; set; }

        public virtual User User { get; set; }
    }
}
