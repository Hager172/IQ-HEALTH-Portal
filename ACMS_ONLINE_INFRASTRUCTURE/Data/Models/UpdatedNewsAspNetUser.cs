using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class UpdatedNewsAspNetUser
{
    public int Id { get; set; }

    public int NewsId { get; set; }

    public string DepartmentId { get; set; } = null!;

    public virtual AspNetUser Department { get; set; } = null!;

    public virtual UpdatedNews News { get; set; } = null!;
}
