namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            Billings = new HashSet<Billing>();
            CompanyAccounts = new HashSet<CompanyAccount>();
            CompanyRoles = new HashSet<CompanyRole>();
            CompanySubscriptions = new HashSet<CompanySubscription>();
            Contractors = new HashSet<Contractor>();
            CompanySettings = new HashSet<CompanySetting>();
            Documents = new HashSet<Document>();
            Documents1 = new HashSet<Document>();
            Documents2 = new HashSet<Document>();
            DocumentOperations = new HashSet<DocumentOperation>();
            DocumentSignatures = new HashSet<DocumentSignature>();
            Employees = new HashSet<Employee>();
            InvoiceAssigners = new HashSet<InvoiceAssigner>();
            PaymentHistories = new HashSet<PaymentHistory>();
            Units = new HashSet<Unit>();
            Usages = new HashSet<Usage>();
            Users = new HashSet<User>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string InnNumber { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        public int? CompanyTypeID { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        [StringLength(1000)]
        public string Bank { get; set; }

        [StringLength(50)]
        public string OKONX { get; set; }

        [StringLength(50)]
        public string MFO { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Home { get; set; }

        [StringLength(50)]
        public string AddressIndex { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string CertificateFile { get; set; }

        [StringLength(50)]
        public string CertSN { get; set; }

        [StringLength(50)]
        public string CertOwner { get; set; }

        [StringLength(50)]
        public string CertOrganisation { get; set; }

        [StringLength(50)]
        public string CertValidTo { get; set; }

        public decimal? CreditBalance { get; set; }

        [StringLength(50)]
        public string SpecialAccount { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        public bool? FreeTrial { get; set; }

        public int? VersionId { get; set; }

        public bool? IsDeleted { get; set; }

        public decimal? TotalBalance { get; set; }

        public decimal? FreeTrialTotalBalance { get; set; }

        public bool? IsGeneratedNewVersion { get; set; }

        public bool? EnableMessages { get; set; }

        public decimal? FreeTrialPackagePrice { get; set; }

        public int? CertificateID { get; set; }

        public virtual AgreementVersion AgreementVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing> Billings { get; set; }

        public virtual Certificate Certificate { get; set; }

        public virtual CompanyType CompanyType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyAccount> CompanyAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyRole> CompanyRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanySubscription> CompanySubscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contractor> Contractors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanySetting> CompanySettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentOperation> DocumentOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentSignature> DocumentSignatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceAssigner> InvoiceAssigners { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistory> PaymentHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unit> Units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usage> Usages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
