using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("Project", Schema = "EventMgmt")]
public partial class Project
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    public bool Active { get; set; }

    [Column("DonorID")]
    public int DonorId { get; set; }

    [ForeignKey("DonorId")]
    [InverseProperty("Projects")]
    public virtual Donor Donor { get; set; } = null!;
}
