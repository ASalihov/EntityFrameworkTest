namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contractor")]
    public partial class Contractor
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int CompanyID { get; set; }

        public bool? IsNew { get; set; }

        public bool? sendAll { get; set; }

        public virtual Company Company { get; set; }

        public virtual User User { get; set; }
    }
}
