using Domain.Base;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public class CorrespondenceWorkflowStep : EntityBase
{

    public int WorkfloStepId { get; set; }

    public Guid CorrespondenceId { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual WorkflowStep WorkfloStep { get; set; } = null!;
}
