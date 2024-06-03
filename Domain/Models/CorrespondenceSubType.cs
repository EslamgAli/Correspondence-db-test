using Domain.Base;

namespace Domain.Models;

public class CorrespondenceSubType : EntityBase
{

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;
    public int CorrespondenceTypeId { get; set; }

    public CorrespondenceType CorrespondenceType { get; set; }
    public virtual ICollection<Correspondence> Correspondences { get; set; } = new List<Correspondence>();
    public virtual ICollection<Template> Templates { get; set; } = new List<Template>();
    // public virtual ICollection<TemplateCorresponednceType> TemplateCorresponednceTypes { get; set; } = new List<TemplateCorresponednceType>();

}
