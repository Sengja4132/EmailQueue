using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("Country", Schema = "EventMgmt")]
public partial class Country
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public bool Active { get; set; }
}
