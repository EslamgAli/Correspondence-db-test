using Domain.Base;

namespace Domain.Models;

public class SentToOrgUnit : EntityBase
{
    public bool IsCopy {  get; set; }
    public int OrgUnitid { get; set; }

    public Guid CorrespondenceId { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual OrgUnit OrgUnit { get; set; } = null!;
}
