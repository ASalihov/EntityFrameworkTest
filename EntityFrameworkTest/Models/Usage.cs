namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usage
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string INN { get; set; }

        public int CompanyID { get; set; }

        public bool IsFree { get; set; }

        public int? DocumentID { get; set; }

        public decimal? ChargePrice { get; set; }

        public virtual Company Company { get; set; }

        public virtual Document Document { get; set; }

        public virtual User User { get; set; }
    }
}
