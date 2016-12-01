namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dimension")]
    public partial class Dimension
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Text { get; set; }
    }
}
