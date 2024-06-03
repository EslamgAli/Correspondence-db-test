using Domain.Base;

namespace Domain.Models;

public class PrivilegeSecurityGroup : EntityBase
{
    public int PrivilegeId { get; set; }

    public int SecurityGroupId { get; set; }

    public virtual Privilege Privilege { get; set; } = null!;

    public virtual SecurityGroup SecurityGroup { get; set; } = null!;
}
