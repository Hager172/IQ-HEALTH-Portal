using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public int RequestType { get; set; }

    public string? RequestStatus { get; set; }

    public string? RequestNote { get; set; }

    public int? MenuId { get; set; }

    public string? StimatedValue { get; set; }

    public DateOnly? StimatedTime { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? LastUpdateBy { get; set; }

    public int? ClientId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? NeedApproval { get; set; }

    public string? Priority { get; set; }

    public string? AssignedTo { get; set; }

    public string? Department { get; set; }

    public DateTime? DueTime { get; set; }

    public virtual Client? Client { get; set; }

    public virtual AspNetUser? DepartmentNavigation { get; set; }

    public virtual ICollection<TicketsReply> TicketsReplies { get; set; } = new List<TicketsReply>();
}
