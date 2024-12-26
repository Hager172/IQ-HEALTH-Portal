using System;
using System.Collections.Generic;

namespace ACMS_ONLINE_INFRASTRUCTURE.Data.Models;

public partial class EntityReviewResponse
{
    public int Id { get; set; }

    public long RatingId { get; set; }

    public string? FeedbackStatus { get; set; }

    public string? ReviewStatus { get; set; }

    public string? Note { get; set; }

    public string LastUpdateBy { get; set; } = null!;

    public string LastUpdateFrom { get; set; } = null!;

    public DateTime LastUpdateDate { get; set; }

    public virtual VendorRating Rating { get; set; } = null!;

    public virtual ICollection<AcmsOption> Options { get; set; } = new List<AcmsOption>();
}
