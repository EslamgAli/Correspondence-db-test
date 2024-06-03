using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public class AttachementType : EntityBase
{

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public virtual ICollection<Attachement> Attachements { get; set; } = new List<Attachement>();
}
