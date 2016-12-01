namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GpsCard")]
    public partial class GpsCard
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        public string CardUID { get; set; }

        public int CardHolderID { get; set; }

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }

        public virtual GpsCardHolder GpsCardHolder { get; set; }
    }
}
