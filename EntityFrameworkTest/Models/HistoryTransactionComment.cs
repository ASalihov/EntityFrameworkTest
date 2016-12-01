namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistoryTransactionComment")]
    public partial class HistoryTransactionComment
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TransactionUID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Text { get; set; }

        public int UserID { get; set; }

        public DateTime UpdateDate { get; set; }

        public virtual User User { get; set; }
    }
}
