using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public class CorrespondenceInbox : EntityBase
{

    public Guid CorrespondenceId { get; set; }

    public int UserOrgUnitId { get; set; }

    public int FromUserOrgUnitId { get; set; }

    public DateTime? SeenAt { get; set; }

    public int? ActionId { get; set; }

    public int? ProcedureId { get; set; }

    public bool CanReplay { get; set; }

    public virtual Status? Action { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual UserOrgUnit FromUserOrgUnit { get; set; } = null!;

    public virtual Procedure? Procedure { get; set; }

    public virtual UserOrgUnit UserOrgUnit { get; set; } = null!;
}
