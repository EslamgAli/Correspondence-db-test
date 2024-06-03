using Domain.Base;
namespace Domain.Models;

public class Template : EntityBase
{
    public string TemplatePath { get; set; } = null!;

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;
    //ICollection<CorrespondenceSubType> CorrespondenceSubTypes {  get; set; }
    public virtual ICollection<Correspondence> Correspondences { get; set; } = new List<Correspondence>();
    public virtual ICollection<CorrespondenceSubType> CorrespondenceSubTypes { get; set; } = new List<CorrespondenceSubType>();
    public virtual ICollection<TemplateCorresponednceType> TemplateCorresponednceTypes { get; set; } = new List<TemplateCorresponednceType>();

    public virtual ICollection<TemplateOrgUnit> TemplateOrgUnits { get; set; } = new List<TemplateOrgUnit>();

    public virtual ICollection<Workflow> Workflows { get; set; } = new List<Workflow>();
}
