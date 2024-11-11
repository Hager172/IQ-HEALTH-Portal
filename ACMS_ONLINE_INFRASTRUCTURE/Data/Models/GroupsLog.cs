using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class GroupsLog
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? NumNotes { get; set; }

    public int? GroupId { get; set; }

    public int? Action { get; set; }

    public string? LastUpdateBy { get; set; }

    public string? LastUpdateFrom { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public virtual Customer? Customer { get; set; }
}
