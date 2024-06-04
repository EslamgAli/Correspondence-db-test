using Domain.Base;

namespace Domain.Models;

public class Archive : EntityBase
{
    public Guid CorrespondenceId { get; set; }

    public int UserOrgUnitId { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual UserOrgUnit UserOrgUnit { get; set; } = null!;
}
