namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActData")]
    public partial class ActData
    {
        public int ID { get; set; }

        public int? ActID { get; set; }

        public string ServiceTitle { get; set; }

        public int? Quantity { get; set; }

        public double? DeliveryCost { get; set; }

        public double? ServicePrice { get; set; }

        public double? Percentage { get; set; }

        public virtual Act Act { get; set; }
    }
}
