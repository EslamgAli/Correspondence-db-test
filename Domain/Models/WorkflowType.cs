using Domain.Base;

namespace Domain.Models;

public class WorkflowType : EntityBase
{
    public string NameAr {  get; set; }
    public string NameEn {  get; set; }
    public virtual ICollection<Workflow> Workflows { get; set; }
}
