using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class PrivilegeCategoryProperties : EntityTypeConfigurationBase<PrivilegeCategory>
{
    public override void Configure(EntityTypeBuilder<PrivilegeCategory> builder)
    {
        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.PrivilegeCategoryCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.PrivilegeCategoryUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
