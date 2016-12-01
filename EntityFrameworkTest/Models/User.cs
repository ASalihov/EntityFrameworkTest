namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Comments = new HashSet<Comment>();
            CompanySettings = new HashSet<CompanySetting>();
            CompanySubscriptions = new HashSet<CompanySubscription>();
            Contractors = new HashSet<Contractor>();
            DocumentAgreementOptions = new HashSet<DocumentAgreementOption>();
            DocumentAgreementOptions1 = new HashSet<DocumentAgreementOption>();
            DocumentAgreementUsers = new HashSet<DocumentAgreementUser>();
            DocumentOperations = new HashSet<DocumentOperation>();
            DocumentSignatures = new HashSet<DocumentSignature>();
            GpsCardHolders = new HashSet<GpsCardHolder>();
            GpsMerchants = new HashSet<GpsMerchant>();
            HistoryTransactionComments = new HashSet<HistoryTransactionComment>();
            Messages = new HashSet<Message>();
            Messages1 = new HashSet<Message>();
            Usages = new HashSet<Usage>();
        }

        public int ID { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(50)]
        public string ConfirmationCode { get; set; }

        public int RoleID { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreateDate { get; set; }

        public int CompanyID { get; set; }

        public int EmployeeID { get; set; }

        public bool? IsInfoReaded { get; set; }

        public bool? IsEnableMessagess { get; set; }

        public bool? IsSupperAdmin { get; set; }

        public bool IsDeleted { get; set; }

        public int? CertificateID { get; set; }

        [StringLength(50)]
        public string Inn { get; set; }

        public virtual Certificate Certificate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanySetting> CompanySettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanySubscription> CompanySubscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contractor> Contractors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentAgreementOption> DocumentAgreementOptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentAgreementOption> DocumentAgreementOptions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentAgreementUser> DocumentAgreementUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentOperation> DocumentOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentSignature> DocumentSignatures { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GpsCardHolder> GpsCardHolders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GpsMerchant> GpsMerchants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryTransactionComment> HistoryTransactionComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages1 { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usage> Usages { get; set; }
    }
}
