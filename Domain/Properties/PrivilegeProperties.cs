using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class PrivilegeProperties : EntityTypeConfigurationBase<Privilege>
{
    public override void Configure(EntityTypeBuilder<Privilege> builder)
    {
        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.PrivilegeCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.PrivilegeUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        base.Configure(builder);
    }
}
