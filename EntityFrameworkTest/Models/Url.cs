namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Url")]
    public partial class Url
    {
        public int ID { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string ShortUrl { get; set; }

        public string OriginalUrl { get; set; }
    }
}
