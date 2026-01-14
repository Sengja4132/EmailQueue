using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mailing_Utility.Models;

[Table("Event", Schema = "EventMgmt")]
public partial class Event
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("CountryID")]
    public int CountryId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Venue { get; set; }

    [Column("EventTypeID")]
    public int EventTypeId { get; set; }

    [Column("ProjectID")]
    public int? ProjectId { get; set; }

    public bool IsOnlineAttendee { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Keywords { get; set; }

    [Column(TypeName = "text")]
    public string? Metadata { get; set; }

    public bool Active { get; set; }
}
