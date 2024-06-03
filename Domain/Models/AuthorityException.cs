

using Domain.Base;

namespace Domain.Models;

public class AuthorityException : EntityBase
{

    public int UserOrgUnitId { get; set; }

    public int OrgUnitId { get; set; }

    public virtual OrgUnit OrgUnit { get; set; } = null!;

    public virtual UserOrgUnit UserOrgUnit { get; set; } = null!;
}
