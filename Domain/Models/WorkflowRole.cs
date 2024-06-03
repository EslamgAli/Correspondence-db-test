using Domain.Base;
namespace Domain.Models;

public class WorkflowRole : EntityBase
{
    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public int? EmpId { get; set; }

    public virtual ICollection<WorkflowStep> WorkflowSteps { get; set; } = new List<WorkflowStep>();
}
