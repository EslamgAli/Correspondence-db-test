using Domain.Base;
namespace Domain.Models;

public class Workflow : EntityBase
{

    public string NameAr { get; set; } = null!;
    public string NameEn { get; set; } = null!;

    public int? TemplateId { get; set; }

    public int? Secret { get; set; }

    public virtual Template? Template { get; set; }
    public int WorkflowTypeId {  get; set; }
    public WorkflowType WorkflowType { get; set; }

    public virtual ICollection<Correspondence> Correspondences { get; set; } = new List<Correspondence>();
    public virtual ICollection<WorkflowStep> WorkflowSteps { get; set; } = new List<WorkflowStep>();
}
