using Domain.Base;
namespace Domain.Models;

public partial class WorkflowStep : EntityBase
{

    public int WorkflowId { get; set; }

    public int WorkflowRoleId { get; set; }

    public int OrderNum { get; set; }

    public bool? CanWithdrawRequest { get; set; }

    public virtual ICollection<CorrespondenceWorkflowStep> CorrespondenceWorkflowSteps { get; set; } = new List<CorrespondenceWorkflowStep>();

    public virtual Workflow Workflow { get; set; } = null!;

    public virtual WorkflowRole WorkflowRole { get; set; } = null!;
}
