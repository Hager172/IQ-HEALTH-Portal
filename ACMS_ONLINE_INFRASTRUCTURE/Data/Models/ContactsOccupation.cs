using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class ContactsOccupation
{
    public int OccupationId { get; set; }

    public string OccupationName { get; set; } = null!;

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<ContactsTemp> ContactsTemps { get; set; } = new List<ContactsTemp>();

    public virtual ICollection<CustomerContact> CustomerContacts { get; set; } = new List<CustomerContact>();
}
