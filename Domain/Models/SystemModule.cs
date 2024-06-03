using Domain.Base;

namespace Domain.Models;

public class SystemModule : EntityBase
{
    public string NameAr {  get; set; }

    public virtual ICollection<PrivilegeCategory> PrivilegeCategories { get; set; } = new List<PrivilegeCategory>();
}
