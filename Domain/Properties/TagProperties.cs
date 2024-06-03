using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class TagProperties : EntityTypeConfigurationBase<Tag>
{

    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.Property(e => e.CreatedBy).IsRequired(true);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.TagCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.TagUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        base.Configure(builder);
    }

}
