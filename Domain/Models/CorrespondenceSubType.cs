using Domain.Base;

namespace Domain.Models;

public class CorrespondenceSubType : EntityBase
{

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public int? TimeFrame { get; set; }
    public int? Status { get; set; }
    public int CorrespondenceTypeId { get; set; }

    public CorrespondenceType CorrespondenceType { get; set; }
    public virtual ICollection<Correspondence> Correspondences { get; set; } = new List<Correspondence>();
    public virtual ICollection<TemplateCorresponednceSubType> TemplateCorresponednceSubTypes { get; set; } = new List<TemplateCorresponednceSubType>();

}
