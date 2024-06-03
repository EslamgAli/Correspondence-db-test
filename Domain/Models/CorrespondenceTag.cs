using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class CorrespondenceTag : EntityBase
{

    public Guid CorrespondenceId { get; set; }

    public int TagId { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}
