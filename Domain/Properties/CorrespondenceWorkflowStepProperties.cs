using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class CorrespondenceWorkflowStepProperties : EntityTypeConfigurationBase<CorrespondenceWorkflowStep>
{
    public override void Configure(EntityTypeBuilder<CorrespondenceWorkflowStep> builder)
    {
        builder.HasOne(d => d.Correspondence).WithMany(p => p.CorrespondenceWorkflowSteps)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CorrespondenceWorkflowSteps_Correspondences");

        builder.HasOne(d => d.WorkfloStep).WithMany(p => p.CorrespondenceWorkflowSteps)
            .HasForeignKey(d => d.WorkfloStepId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CorrespondenceWorkflowSteps_WorkflowSteps");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.CorrespondenceWorkflowStepCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.CorrespondenceWorkflowStepUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);
        base.Configure(builder);
    }
}
