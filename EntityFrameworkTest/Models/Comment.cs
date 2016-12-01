namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public int ID { get; set; }

        [StringLength(300)]
        public string Message { get; set; }

        public int UserID { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? DocumentID { get; set; }

        public virtual Document Document { get; set; }

        public virtual User User { get; set; }
    }
}
