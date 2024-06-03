
using Domain.Base;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models;

public class OrgUnit : EntityBase
{
    public string Name { get; set; } = null!;
    public HierarchyId? Hid { get; set; }
    public int Lvl { get; set; }

    public bool IsActive { get; set; }

    public int OrgUnitTypeId { get; set; }

    public virtual ICollection<ApprovalAuthorityException> ApprovalAuthorityExceptions { get; set; } = new List<ApprovalAuthorityException>();

    public virtual ICollection<GroupDetail> GroupDetails { get; set; } = new List<GroupDetail>();

    public virtual OrgUnitType OrgUnitType { get; set; } = null!;
    public virtual ICollection<CorrespondenceType> CorrespondenceTypes { get; set; } = new List<CorrespondenceType>();

    public virtual ICollection<SentToOrgUnit> SentToOrgUnits { get; set; } = new List<SentToOrgUnit>();

    public virtual ICollection<UserOrgUnit> UserOrgUnits { get; set; } = new List<UserOrgUnit>();
}
