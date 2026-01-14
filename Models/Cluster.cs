using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("Cluster", Schema = "EventMgmt")]
public partial class Cluster
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Cluster")]
    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
