namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentHistory")]
    public partial class PaymentHistory
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public decimal Balance { get; set; }

        public bool IsFree { get; set; }

        public int CompanyID { get; set; }

        [StringLength(100)]
        public string DocNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BankDate { get; set; }

        public virtual Company Company { get; set; }
    }
}
