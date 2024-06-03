using Domain.Base;

namespace Domain.Models;

public  class Draft : EntityBase
{

    public Guid CorrespondenceId { get; set; }

    public int UserOrgUnitId { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual UserOrgUnit UserOrgUnit { get; set; } = null!;
}
