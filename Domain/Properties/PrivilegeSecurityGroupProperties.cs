using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class PrivilegeSecurityGroupProperties : EntityTypeConfigurationBase<PrivilegeSecurityGroup>
{
    public override void Configure(EntityTypeBuilder<PrivilegeSecurityGroup> builder)
    {
        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.PrivilegeSecurityGroupCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.PrivilegeSecurityGroupUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
