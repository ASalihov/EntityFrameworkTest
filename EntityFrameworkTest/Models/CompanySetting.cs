namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CompanySetting
    {
        public int ID { get; set; }

        public int CompanyId { get; set; }

        public int ApproverId { get; set; }

        public bool IsDSRequired { get; set; }

        public bool IsProcessesMonitored { get; set; }

        public virtual Company Company { get; set; }

        public virtual User User { get; set; }
    }
}
