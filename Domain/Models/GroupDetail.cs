using Domain.Base;

namespace Domain.Models;

public class GroupDetail : EntityBase
{
    public int GroupId { get; set; }

    public int? UserOrgUnitId { get; set; }

    public int? OrgUnitId { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual OrgUnit? OrgUnit { get; set; }

    public virtual UserOrgUnit? UserOrgUnit { get; set; }
}
