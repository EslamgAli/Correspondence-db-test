using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class WorkflowProperties : EntityTypeConfigurationBase<Workflow>
{
    public override void Configure(EntityTypeBuilder<Workflow> builder)
    {
        builder.Property(e => e.NameAr).HasMaxLength(50);
        builder.Property(e => e.NameEn).HasMaxLength(50);
        builder.Property(e => e.CreatedBy).IsRequired(false);

        builder.HasOne(d => d.Template).WithMany(p => p.Workflows)
            .HasForeignKey(d => d.TemplateId)
            .HasConstraintName("FK_Workflows_Templates");

        builder.HasOne(d => d.WorkflowType)
            .WithMany(p => p.Workflows)
            .HasForeignKey(d => d.WorkflowTypeId);

        builder.HasData([
                new Workflow{
                    Id = 1,
                    NameAr="هيكل تنظيمي",
                    NameEn="Hierarchy orgunit",
                    WorkflowTypeId = 1,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
                },
                new Workflow {
                    Id = 2,
                    NameAr="مخصص",
                    NameEn="ad-hock",
                    WorkflowTypeId = 2,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)

                }
            ]);
        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.WorkflowCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.WorkflowUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
