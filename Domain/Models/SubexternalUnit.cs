using Domain.Base;

namespace Domain.Models;

public class SubexternalUnit : EntityBase
{
    public string NameAr {  get; set; }
    public string NameEn { get; set; }
    public virtual ICollection<ExternalUnit> ExternalUnits { get; set; } = new List<ExternalUnit>();
}
