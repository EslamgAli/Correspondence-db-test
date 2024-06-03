using Domain.Base;
namespace Domain.Models;

public class ExternalUnitType : EntityBase
{
    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public virtual ICollection<ExternalUnit> ExternalUnits { get; set; } = new List<ExternalUnit>();
}
