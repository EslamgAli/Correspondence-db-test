using Domain.Base;

namespace Domain.Models;

public partial class CorrespondenceType : EntityBase
{
    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public bool IsExternalUnits { get; set; }//??????

    public int? OrgUnitResponsibilityId { get; set; }///?????

    public int? Statuse { get; set; }

    public int? TimeFrame { get; set; }
    public OrgUnit? OrgUnitResponsibility { get; set; }

    public ICollection<CorrespondenceSubType> CorrespondenceSubTypes { get; set; }
    public virtual ICollection<Correspondence> Correspondences { get; set; } = new List<Correspondence>();
    public virtual ICollection<TemplateCorresponednceType> TemplateCorresponednceTypes { get; set; } = new List<TemplateCorresponednceType>();
}
