namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentFileItem
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime BankDate { get; set; }

        [Required]
        [StringLength(150)]
        public string INN { get; set; }

        public decimal Balance { get; set; }

        public int PaymentFileID { get; set; }

        public bool IsPaid { get; set; }

        [Required]
        [StringLength(500)]
        public string Reason { get; set; }

        public virtual PaymentFile PaymentFile { get; set; }
    }
}
