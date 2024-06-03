﻿using Domain.Base;

namespace Domain.Models;

public class Status : EntityBase
{
    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public virtual ICollection<CorrespondenceInbox> CorrespondenceInboxes { get; set; } = new List<CorrespondenceInbox>();

    public virtual ICollection<CorrespondencesOutbox> CorrespondencesOutboxes { get; set; } = new List<CorrespondencesOutbox>();

    public virtual ICollection<Tracker> Trackers { get; set; } = new List<Tracker>();
}
