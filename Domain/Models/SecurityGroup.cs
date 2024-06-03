using Domain.Base;

namespace Domain.Models;

public class SecurityGroup : EntityBase
{
    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<PrivilegeSecurityGroup> RoleSecurityGroups { get; set; } = new List<PrivilegeSecurityGroup>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
