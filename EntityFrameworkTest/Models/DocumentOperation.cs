namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentOperation")]
    public partial class DocumentOperation
    {
        public int ID { get; set; }

        public int DocumentID { get; set; }

        public int TypeID { get; set; }

        public int CompanyID { get; set; }

        public int UserID { get; set; }

        public DateTime AddedDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsNew { get; set; }

        public virtual Company Company { get; set; }

        public virtual Document Document { get; set; }

        public virtual DocumentOperationType DocumentOperationType { get; set; }

        public virtual User User { get; set; }
    }
}
