namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PackagePrice")]
    public partial class PackagePrice
    {
        public int ID { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public bool IsActive { get; set; }
    }
}
