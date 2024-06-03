using Domain.Base;

namespace Domain.Models;

public class SentToUserOrgUnit : EntityBase
{
    public bool IsCopy { get; set; }
    public int UserOrgUnitId { get; set; }

    public Guid CorrespondenceId { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual UserOrgUnit UserOrgUnit { get; set; } = null!;
}
