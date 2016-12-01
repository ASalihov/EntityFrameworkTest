namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BankInfo")]
    public partial class BankInfo
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MFO { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(10)]
        public string RegionCode { get; set; }
    }
}
