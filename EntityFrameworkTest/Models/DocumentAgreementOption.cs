namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentAgreementOption")]
    public partial class DocumentAgreementOption
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int DocumentID { get; set; }

        public bool RequiredSignature { get; set; }

        public bool ForceReject { get; set; }

        public int ApproverID { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(1000)]
        public string Comment { get; set; }

        public int ProccessType { get; set; }

        public virtual Document Document { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
