namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Act")]
    public partial class Act
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Act()
        {
            ActDatas = new HashSet<ActData>();
        }

        public int ID { get; set; }

        public int DocumentID { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateFromNumber { get; set; }

        [StringLength(50)]
        public string ContractNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateFromContractNumber { get; set; }

        public decimal? TotalPrice { get; set; }

        public int? ApproverId { get; set; }

        public string Description { get; set; }

        [StringLength(250)]
        public string ApproverName { get; set; }

        public decimal? PaidEarlier { get; set; }

        public decimal? DeliveryTotalCost { get; set; }

        public virtual Document Document { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActData> ActDatas { get; set; }
    }
}
