using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("ParticipantType", Schema = "EventMgmt")]
public partial class ParticipantType
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Type { get; set; }

    public bool Active { get; set; }
}
