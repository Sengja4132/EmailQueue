using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("EmailQueue")]
public partial class EmailQueue
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateSentOut { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Recipient { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Subject { get; set; } = null!;

    [Column(TypeName = "text")]
    public string HtmlContent { get; set; } = null!;
}
