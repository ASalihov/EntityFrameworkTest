namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            Acts = new HashSet<Act>();
            Comments = new HashSet<Comment>();
            DocumentAgreementOptions = new HashSet<DocumentAgreementOption>();
            DocumentAgreementUsers = new HashSet<DocumentAgreementUser>();
            DocumentHistories = new HashSet<DocumentHistory>();
            DocumentOperations = new HashSet<DocumentOperation>();
            DocumentSignatures = new HashSet<DocumentSignature>();
            Invoices = new HashSet<Invoice>();
            Usages = new HashSet<Usage>();
        }

        public int ID { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int TypeID { get; set; }

        public int? ContractorID { get; set; }

        public int CompanyID { get; set; }

        public int? StatusID { get; set; }

        public int? LocalStatusID { get; set; }

        public bool? IsSign { get; set; }

        public DateTime? SignDate { get; set; }

        public DateTime? SentDate { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? AgreementDate { get; set; }

        public bool? IsArchive { get; set; }

        [StringLength(50)]
        public string PdfFile { get; set; }

        [StringLength(50)]
        public string UniqueID { get; set; }

        public bool? IsFullDeleted { get; set; }

        [StringLength(50)]
        public string ZipFile { get; set; }

        public DateTime? ViewedDate { get; set; }

        public bool WithAct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Act> Acts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual Company Company2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentAgreementOption> DocumentAgreementOptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentAgreementUser> DocumentAgreementUsers { get; set; }

        public virtual DocumentStatu DocumentStatu { get; set; }

        public virtual DocumentStatusLocal DocumentStatusLocal { get; set; }

        public virtual DocumentType DocumentType { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentHistory> DocumentHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentOperation> DocumentOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentSignature> DocumentSignatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usage> Usages { get; set; }
    }
}
