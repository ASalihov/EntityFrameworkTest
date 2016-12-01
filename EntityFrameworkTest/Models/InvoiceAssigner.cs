namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceAssigner
    {
        public int ID { get; set; }

        public int? DirectorID { get; set; }

        public int? BookerID { get; set; }

        public int? SupplierID { get; set; }

        public int CompanyID { get; set; }

        public virtual Company Company { get; set; }
    }
}
