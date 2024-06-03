using Domain.Base;

namespace Domain.Models;

public class CorrespondenceInbox : EntityBase
{

    public Guid CorrespondenceId { get; set; }

    public int UserOrgUnitId { get; set; }

    public int FromUserOrgUnitId { get; set; }

    public DateTime? SeenAt { get; set; }

    public int? StatusId { get; set; }

    public int? ProcedureId { get; set; }

    public bool CanReplay { get; set; }

    public virtual Status? Status { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual UserOrgUnit FromUserOrgUnit { get; set; } = null!;

    public virtual Procedure? Procedure { get; set; }

    public virtual UserOrgUnit UserOrgUnit { get; set; } = null!;
}
