namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyRole")]
    public partial class CompanyRole
    {
        public int ID { get; set; }

        public int RoleID { get; set; }

        public int CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public virtual Role Role { get; set; }
    }
}
