namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolePermission")]
    public partial class RolePermission
    {
        public int ID { get; set; }

        public int Permission { get; set; }

        public int RoleID { get; set; }

        public virtual Role Role { get; set; }
    }
}
