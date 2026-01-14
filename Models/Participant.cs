using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("Participant", Schema = "EventMgmt")]
public partial class Participant
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("ParticipantTypeID")]
    public int ParticipantTypeId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Organization { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? SubUnit { get; set; }

    [Column("EventID")]
    public int EventId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PositionName { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Contact { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Donor { get; set; }

    public bool IsOnlineAttendee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    public bool Active { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Nationality { get; set; } = null!;

    public int? CountryOfOrigin { get; set; }
}
