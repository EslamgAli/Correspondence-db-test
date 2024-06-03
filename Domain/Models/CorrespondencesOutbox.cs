using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public class CorrespondencesOutbox : EntityBase
{

    public int UserOrgUnitId { get; set; }

    public int ActionId { get; set; }

    public int ProcedureId { get; set; }

    public int ToUserOrgUnitId { get; set; }

    public Guid CorrespondenceId { get; set; }

    public virtual Status Action { get; set; } = null!;

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual Procedure Procedure { get; set; } = null!;

    public virtual UserOrgUnit ToUserOrgUnit { get; set; } = null!;

    public virtual UserOrgUnit UserOrgUnit { get; set; } = null!;
}
