using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class SecurityGroupProperties : EntityTypeConfigurationBase<SecurityGroup>
{
    public override void Configure(EntityTypeBuilder<SecurityGroup> builder)
    {
        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.SecurityGroupCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.SecurityGroupUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        base.Configure(builder);
    }
}
