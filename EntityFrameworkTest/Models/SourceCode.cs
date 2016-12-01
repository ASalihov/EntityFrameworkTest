namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SourceCode")]
    public partial class SourceCode
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Version { get; set; }

        [Required]
        [StringLength(200)]
        public string Revision { get; set; }

        public DateTime BuidlDate { get; set; }
    }
}
