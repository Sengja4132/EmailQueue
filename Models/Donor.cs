using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("Donor", Schema = "EventMgmt")]
public partial class Donor
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Donor")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
