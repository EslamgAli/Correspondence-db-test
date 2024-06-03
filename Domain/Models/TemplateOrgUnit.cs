using Domain.Base;

namespace Domain.Models;

public class TemplateOrgUnit : EntityBase
{

    public int OrgUnitId { get; set; }

    public int TemplateId { get; set; }

    public virtual UserOrgUnit OrgUnit { get; set; } = null!;

    public virtual Template Template { get; set; } = null!;
}
