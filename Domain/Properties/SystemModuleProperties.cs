using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class SystemModuleProperties : EntityTypeConfigurationBase<SystemModule>
{
    public override void Configure(EntityTypeBuilder<SystemModule> builder)
    {
        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.SystemModuleCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.SystemModuleUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        base.Configure(builder);
    }
}
