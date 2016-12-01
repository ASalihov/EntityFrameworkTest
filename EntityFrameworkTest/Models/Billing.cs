namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Billing")]
    public partial class Billing
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public int CreditBalance { get; set; }

        public int CompanyID { get; set; }

        public int TotalBalance { get; set; }

        public virtual Billing Billing1 { get; set; }

        public virtual Billing Billing2 { get; set; }

        public virtual Company Company { get; set; }
    }
}
