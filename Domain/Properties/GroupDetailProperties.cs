using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class GroupDetailProperties : EntityTypeConfigurationBase<GroupDetail>
{
    public override void Configure(EntityTypeBuilder<GroupDetail> builder)
    {
        builder.HasOne(d => d.Group).WithMany(p => p.GroupDetails)
            .HasForeignKey(d => d.GroupId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_GroupDetails_Groups");

        builder.HasOne(d => d.OrgUnit).WithMany(p => p.GroupDetails)
            .HasForeignKey(d => d.OrgUnitId)
            .HasConstraintName("FK_GroupDetails_OrgUnits");

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.GroupDetails)
            .HasForeignKey(d => d.UserOrgUnitId)
            .HasConstraintName("FK_GroupDetails_UserOrgUnit");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.GroupDetailCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.GroupDetailUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
