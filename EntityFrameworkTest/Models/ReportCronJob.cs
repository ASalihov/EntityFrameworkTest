namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportCronJob")]
    public partial class ReportCronJob
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public DateTime StartedDate { get; set; }

        public DateTime? FinishedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Token { get; set; }
    }
}
