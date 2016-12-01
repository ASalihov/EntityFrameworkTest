namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanySubscription")]
    public partial class CompanySubscription
    {
        public int ID { get; set; }

        public int CompanyID { get; set; }

        public int UserID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? PaymentDate { get; set; }

        public bool IsPaid { get; set; }

        [StringLength(50)]
        public string SerialKey { get; set; }

        public int SubscriptionStatusID { get; set; }

        public int SubscriptionID { get; set; }

        public virtual Company Company { get; set; }

        public virtual Subscription Subscription { get; set; }

        public virtual SubscriptionStatu SubscriptionStatu { get; set; }

        public virtual User User { get; set; }
    }
}
