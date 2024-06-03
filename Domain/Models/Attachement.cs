using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public class Attachement : EntityBase
{

    public string Path { get; set; } = null!;

    public int AttachementTypeId { get; set; }

    public Guid CorrespondenceId { get; set; }

    public virtual AttachementType AttachementType { get; set; } = null!;

    public virtual Correspondence Correspondence { get; set; } = null!;
}
