namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentHistory")]
    public partial class DocumentHistory
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? CreateDate { get; set; }

        public int DocumentID { get; set; }

        public virtual Document Document { get; set; }
    }
}
