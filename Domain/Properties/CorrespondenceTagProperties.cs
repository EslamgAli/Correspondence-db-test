using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class CorrespondenceTagProperties : EntityTypeConfigurationBase<CorrespondenceTag>
{
    public override void Configure(EntityTypeBuilder<CorrespondenceTag> builder)
    {
        builder.Property(e => e.CreatedBy).IsRequired(true);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.CorrespondenceTagCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.CorrespondenceTagUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
