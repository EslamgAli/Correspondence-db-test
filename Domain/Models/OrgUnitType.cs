using Domain.Base;

namespace Domain.Models;

public partial class OrgUnitType : EntityBase
{

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public virtual ICollection<OrgUnit> OrgUnits { get; set; } = new List<OrgUnit>();
}
