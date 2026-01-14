using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("Category", Schema = "EventMgmt")]
public partial class Category
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("ClusterID")]
    public int ClusterId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    public bool Active { get; set; }

    [ForeignKey("ClusterId")]
    [InverseProperty("Categories")]
    public virtual Cluster Cluster { get; set; } = null!;
}
