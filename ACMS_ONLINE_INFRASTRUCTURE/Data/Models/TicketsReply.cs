using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class TicketsReply
{
    public int ReplyId { get; set; }

    public int TicketId { get; set; }

    public int ReplyClientId { get; set; }

    public string? ReplyNote { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? Priority { get; set; }

    public bool? NeedApproval { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? RequestStatus { get; set; }

    public DateTime? DueTime { get; set; }

    public virtual Client ReplyClient { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
