using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class NoteGroup
{
    public int GroupId { get; set; }

    public decimal NoteId { get; set; }

    public int Serial { get; set; }

    public long? BillTempId { get; set; }
}
