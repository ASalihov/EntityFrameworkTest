namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceData")]
    public partial class InvoiceData
    {
        public int ID { get; set; }

        public int InvoiceID { get; set; }

        [StringLength(250)]
        public string ServiceTitle { get; set; }

        [StringLength(50)]
        public string Dimension { get; set; }

        public int? Quantity { get; set; }

        public double? PricePerDimension { get; set; }

        public double? DeliveryCost { get; set; }

        public double? TaxRate { get; set; }

        public double? TaxAmount { get; set; }

        public double? VATRate { get; set; }

        public double? VATAmount { get; set; }

        public double? VATDeliveryCost { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
