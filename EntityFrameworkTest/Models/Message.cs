namespace EntityFrameworkTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public int ID { get; set; }

        public int SenderUserId { get; set; }

        public int RecipientUserId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Body { get; set; }

        public DateTime AddedDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsNew { get; set; }

        [StringLength(250)]
        public string Subject { get; set; }

        public int MessageType { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
