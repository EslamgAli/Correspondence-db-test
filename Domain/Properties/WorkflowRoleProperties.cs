using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class WorkflowRoleProperties : EntityTypeConfigurationBase<WorkflowRole>
{
    public override void Configure(EntityTypeBuilder<WorkflowRole> builder)
    {
        builder.Property(e => e.NameAr).HasMaxLength(100);
        builder.Property(e => e.NameEn).HasMaxLength(100);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.WorkflowRoleCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.WorkflowRoleUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
