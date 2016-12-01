namespace EntityFrameworkTest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {
        }

        public virtual DbSet<Act> Acts { get; set; }
        public virtual DbSet<ActData> ActDatas { get; set; }
        public virtual DbSet<AgreementVersion> AgreementVersions { get; set; }
        public virtual DbSet<BankInfo> BankInfoes { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAccount> CompanyAccounts { get; set; }
        public virtual DbSet<CompanyRole> CompanyRoles { get; set; }
        public virtual DbSet<CompanySetting> CompanySettings { get; set; }
        public virtual DbSet<CompanySubscription> CompanySubscriptions { get; set; }
        public virtual DbSet<CompanyType> CompanyTypes { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<Dimension> Dimensions { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentAgreementOption> DocumentAgreementOptions { get; set; }
        public virtual DbSet<DocumentAgreementUser> DocumentAgreementUsers { get; set; }
        public virtual DbSet<DocumentHistory> DocumentHistories { get; set; }
        public virtual DbSet<DocumentOperation> DocumentOperations { get; set; }
        public virtual DbSet<DocumentOperationType> DocumentOperationTypes { get; set; }
        public virtual DbSet<DocumentSignature> DocumentSignatures { get; set; }
        public virtual DbSet<DocumentStatu> DocumentStatus { get; set; }
        public virtual DbSet<DocumentStatusLocal> DocumentStatusLocals { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GpsCard> GpsCards { get; set; }
        public virtual DbSet<GpsCardHolder> GpsCardHolders { get; set; }
        public virtual DbSet<GpsLabel> GpsLabels { get; set; }
        public virtual DbSet<GpsMerchant> GpsMerchants { get; set; }
        public virtual DbSet<GpsTerminal> GpsTerminals { get; set; }
        public virtual DbSet<GpsTransaction> GpsTransactions { get; set; }
        public virtual DbSet<HistoryTemplate> HistoryTemplates { get; set; }
        public virtual DbSet<HistoryTransactionComment> HistoryTransactionComments { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceAssigner> InvoiceAssigners { get; set; }
        public virtual DbSet<InvoiceData> InvoiceDatas { get; set; }
        public virtual DbSet<InvoiceReestr> InvoiceReestrs { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<PackagePrice> PackagePrices { get; set; }
        public virtual DbSet<PaymentFile> PaymentFiles { get; set; }
        public virtual DbSet<PaymentFileItem> PaymentFileItems { get; set; }
        public virtual DbSet<PaymentHistory> PaymentHistories { get; set; }
        public virtual DbSet<ReportCronJob> ReportCronJobs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<SourceCode> SourceCodes { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionStatu> SubscriptionStatus { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Url> Urls { get; set; }
        public virtual DbSet<Usage> Usages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Act>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<Act>()
                .Property(e => e.ContractNumber)
                .IsFixedLength();

            modelBuilder.Entity<Act>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Act>()
                .Property(e => e.ApproverName)
                .IsUnicode(false);

            modelBuilder.Entity<ActData>()
                .Property(e => e.ServiceTitle)
                .IsUnicode(false);

            modelBuilder.Entity<AgreementVersion>()
                .HasMany(e => e.Companies)
                .WithOptional(e => e.AgreementVersion)
                .HasForeignKey(e => e.VersionId);

            modelBuilder.Entity<Billing>()
                .HasOptional(e => e.Billing1)
                .WithRequired(e => e.Billing2);

            modelBuilder.Entity<Company>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.CreditBalance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Company>()
                .Property(e => e.TotalBalance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Company>()
                .Property(e => e.FreeTrialTotalBalance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Company>()
                .Property(e => e.FreeTrialPackagePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Billings)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyAccounts)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyRoles)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanySubscriptions)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Contractors)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Documents)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Documents1)
                .WithOptional(e => e.Company1)
                .HasForeignKey(e => e.ContractorID);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Documents2)
                .WithRequired(e => e.Company2)
                .HasForeignKey(e => e.CompanyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.DocumentOperations)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.InvoiceAssigners)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.PaymentHistories)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Usages)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Acts)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.DocumentHistories)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.DocumentOperations)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.DocumentSignatures)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentOperationType>()
                .HasMany(e => e.DocumentOperations)
                .WithRequired(e => e.DocumentOperationType)
                .HasForeignKey(e => e.TypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentSignature>()
                .Property(e => e.SignedContent)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentStatu>()
                .HasMany(e => e.Documents)
                .WithOptional(e => e.DocumentStatu)
                .HasForeignKey(e => e.StatusID);

            modelBuilder.Entity<DocumentStatusLocal>()
                .HasMany(e => e.Documents)
                .WithOptional(e => e.DocumentStatusLocal)
                .HasForeignKey(e => e.LocalStatusID);

            modelBuilder.Entity<DocumentType>()
                .HasMany(e => e.Documents)
                .WithRequired(e => e.DocumentType)
                .HasForeignKey(e => e.TypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Acts)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.ApproverId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoices)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.DirectorID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoices1)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.AnotherPersonID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoices2)
                .WithOptional(e => e.Employee2)
                .HasForeignKey(e => e.BookerID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoices3)
                .WithOptional(e => e.Employee3)
                .HasForeignKey(e => e.SupplierID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GpsCardHolder>()
                .HasMany(e => e.GpsCards)
                .WithRequired(e => e.GpsCardHolder)
                .HasForeignKey(e => e.CardHolderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GpsLabel>()
                .HasMany(e => e.GpsTransactions)
                .WithOptional(e => e.GpsLabel)
                .HasForeignKey(e => e.LabelID);

            modelBuilder.Entity<GpsMerchant>()
                .HasMany(e => e.GpsTerminals)
                .WithRequired(e => e.GpsMerchant)
                .HasForeignKey(e => e.MerchantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GpsMerchant>()
                .HasMany(e => e.GpsTransactions)
                .WithOptional(e => e.GpsMerchant)
                .HasForeignKey(e => e.MerchantID);

            modelBuilder.Entity<HistoryTransactionComment>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDatas)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceReestr>()
                .HasMany(e => e.Invoices)
                .WithOptional(e => e.InvoiceReestr)
                .HasForeignKey(e => e.ReestrID);

            modelBuilder.Entity<Message>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<PackagePrice>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PaymentFile>()
                .HasMany(e => e.PaymentFileItems)
                .WithRequired(e => e.PaymentFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentFileItem>()
                .Property(e => e.Balance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PaymentHistory>()
                .Property(e => e.Balance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.CompanyRoles)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.RolePermissions)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Subscription>()
                .HasMany(e => e.CompanySubscriptions)
                .WithRequired(e => e.Subscription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubscriptionStatu>()
                .HasMany(e => e.CompanySubscriptions)
                .WithRequired(e => e.SubscriptionStatu)
                .HasForeignKey(e => e.SubscriptionStatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usage>()
                .Property(e => e.ChargePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CompanySettings)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ApproverId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CompanySubscriptions)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contractors)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DocumentAgreementOptions)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ApproverID);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DocumentAgreementOptions1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DocumentOperations)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.GpsCardHolders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.GpsMerchants)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.HistoryTransactionComments)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.RecipientUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Messages1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.SenderUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Usages)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
