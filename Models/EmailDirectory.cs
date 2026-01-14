using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("EmailDirectory")]
public partial class EmailDirectory
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string EmailAddress { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? EmailGroup { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    public bool Active { get; set; }
}
