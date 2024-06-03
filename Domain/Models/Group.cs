using Domain.Base;

namespace Domain.Models;

public class Group : EntityBase
{

    public string Name { get; set; } = null!;

    public int UserOrgUnitId { get; set; }

    public int GroupTypeId { get; set; }

    public virtual ICollection<GroupDetail> GroupDetails { get; set; } = new List<GroupDetail>();

    public virtual UserOrgUnit UserOrgUnit { get; set; } = null!;
}
