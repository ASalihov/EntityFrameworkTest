namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageTemplate")]
    public partial class MessageTemplate
    {
        public int ID { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public int? TemplateType { get; set; }

        public int? TemplateCategory { get; set; }

        public bool IsActive { get; set; }
    }
}
