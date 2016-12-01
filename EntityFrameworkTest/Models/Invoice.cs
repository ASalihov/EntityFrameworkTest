namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            InvoiceDatas = new HashSet<InvoiceData>();
        }

        public int ID { get; set; }

        public int DocumentID { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        public DateTime? DateFromNumber { get; set; }

        public DateTime? DateToNumber { get; set; }

        [StringLength(50)]
        public string ContractNumber { get; set; }

        public DateTime? DateFromContractNumber { get; set; }

        public DateTime? DateToContractNumber { get; set; }

        public double? TotalPrice { get; set; }

        public double? TotalPriceWithoutTax { get; set; }

        public double? TotalPriceWithVAT { get; set; }

        public double? TotalPriceToPay { get; set; }

        public int? ReestrID { get; set; }

        public int? DirectorID { get; set; }

        public int? BookerID { get; set; }

        public int? SupplierID { get; set; }

        [StringLength(50)]
        public string AnotherPerson { get; set; }

        [StringLength(50)]
        public string AnotherPersonNumber { get; set; }

        [StringLength(50)]
        public string AnotherPersonDate { get; set; }

        public int? AnotherPersonID { get; set; }

        [StringLength(50)]
        public string AnotherPerson2 { get; set; }

        [StringLength(100)]
        public string AccountNumber { get; set; }

        public int? Rate { get; set; }

        public double? ExchangeRate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExchangeRateDate { get; set; }

        [StringLength(100)]
        public string AccountName { get; set; }

        public bool? IsUSD { get; set; }

        public virtual Document Document { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual Employee Employee2 { get; set; }

        public virtual Employee Employee3 { get; set; }

        public virtual InvoiceReestr InvoiceReestr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceData> InvoiceDatas { get; set; }
    }
}
