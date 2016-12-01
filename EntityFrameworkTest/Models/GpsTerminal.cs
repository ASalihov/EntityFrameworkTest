namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GpsTerminal")]
    public partial class GpsTerminal
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        public string TerminalUID { get; set; }

        public int MerchantID { get; set; }

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }

        public virtual GpsMerchant GpsMerchant { get; set; }
    }
}
