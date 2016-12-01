namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HistoryTemplate")]
    public partial class HistoryTemplate
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Value { get; set; }
    }
}
