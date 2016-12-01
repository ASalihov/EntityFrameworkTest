namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyAccount")]
    public partial class CompanyAccount
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Code { get; set; }

        public int CompanyID { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsPrimary { get; set; }

        public virtual Company Company { get; set; }
    }
}
