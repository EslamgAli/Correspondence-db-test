using Domain.Base;

namespace Domain.Models;

public class PrivilegeCategory : EntityBase
{
    public string NameAr {  get; set; }
    public string NameEn { get; set; }
    public int SortNum {  get; set; }
    public int SystemModuleId {  get; set; }
    public SystemModule SystemModule {  get; set; }
    public virtual ICollection<Privilege> UserPrivileges { get; set; } = new List<Privilege>();
}
