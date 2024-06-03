using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class WorkflowStepProperties : EntityTypeConfigurationBase<WorkflowStep>
{
    public override void Configure(EntityTypeBuilder<WorkflowStep> builder)
    {
        builder.HasOne(d => d.Workflow).WithMany(p => p.WorkflowSteps)
            .HasForeignKey(d => d.WorkflowId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_WorkflowSteps_Workflows");

        builder.HasOne(d => d.WorkflowRole).WithMany(p => p.WorkflowSteps)
            .HasForeignKey(d => d.WorkflowRoleId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_WorkflowSteps_WorkflowRoles");


        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.WorkflowStepCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.WorkflowStepUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
