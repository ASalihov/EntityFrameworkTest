namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Unit")]
    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            Employees = new HashSet<Employee>();
        }

        public int ID { get; set; }

        public int CompanyID { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public int? ParentID { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Home { get; set; }

        [StringLength(50)]
        public string AddressIndex { get; set; }

        public bool SendTo { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
