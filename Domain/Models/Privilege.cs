
using Domain.Base;

namespace Domain.Models;

public class Privilege : EntityBase
{
    public string NameAr {  get; set; }
    public string NameEn {  get; set; }
    public int UserPrivilegeCategoryId {  get; set; }
    public PrivilegeCategory UserPrivilegeCategory { get; set; }
}
