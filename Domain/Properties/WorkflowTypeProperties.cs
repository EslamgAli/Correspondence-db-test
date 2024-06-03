using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class WorkflowTypeProperties : EntityTypeConfigurationBase<WorkflowType>
{
    public override void Configure(EntityTypeBuilder<WorkflowType> builder)
    {

        builder.HasData([

            new WorkflowType {
                Id = 1,
                NameAr="هيكل تنظيمي",
                NameEn="Hierarchy orgunit",
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)

            },
            new WorkflowType {
                Id = 2,
                NameAr="مخصص",
                NameEn="ad-hock",
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)

            },
            new WorkflowType {
                Id = 3,
                NameAr="تسلسلي",
                NameEn="Sequential",
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)

            }

        ]);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.WorkflowTypeCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.WorkflowTypeUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
