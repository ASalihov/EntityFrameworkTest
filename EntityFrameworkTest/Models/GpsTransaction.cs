namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GpsTransaction")]
    public partial class GpsTransaction
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TransactionUID { get; set; }

        public int? LabelID { get; set; }

        public int? MerchantID { get; set; }

        public virtual GpsLabel GpsLabel { get; set; }

        public virtual GpsMerchant GpsMerchant { get; set; }
    }
}
