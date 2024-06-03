using Domain.Base;

namespace Domain.Models;

public class ExternalUnit : EntityBase
{
    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Mail { get; set; }

    public int ExternalUnitTypeId { get; set; }
    public int? SubexternalUnitId {  get; set; }
    public SubexternalUnit SubexternalUnit { get; set; }

    public virtual ICollection<Correspondence> Correspondences { get; set; } = new List<Correspondence>();
    public virtual ExternalUnitType ExternalUnitType { get; set; } = null!;

    public virtual ICollection<SentToExternalUnit> SentToExternalUnits { get; set; } = new List<SentToExternalUnit>();
}
