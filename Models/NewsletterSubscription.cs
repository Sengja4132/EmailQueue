using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("NewsletterSubscription")]
public partial class NewsletterSubscription
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column(TypeName = "text")]
    public string? Grp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Org { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CountryCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Note { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Format { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column(TypeName = "text")]
    public string? Status { get; set; }

    [Column(TypeName = "text")]
    public string? Remark { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }
}
