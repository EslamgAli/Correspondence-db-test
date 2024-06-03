using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class UserOrgUnitProperties : EntityTypeConfigurationBase<UserOrgUnit>
{
    public override void Configure(EntityTypeBuilder<UserOrgUnit> builder)
    {
        builder.ToTable("UserOrgUnit");

        builder.Property(e => e.JobTitle).HasMaxLength(50);

        builder.HasOne(d => d.OrgUnit).WithMany(p => p.UserOrgUnits)
            .HasForeignKey(d => d.OrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_UserOrgUnit_OrgUnits");

        builder.HasOne(d => d.User).WithMany(p => p.UserOrgUnits)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_UserOrgUnit_Users");

        /*  builder.HasMany(d => d.Employees)
            //  .WithOne(d => d.DirectManager)
              .HasForeignKey(d => d.DirectManagerId)
              .OnDelete(DeleteBehavior.ClientSetNull);*/

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.UserOrgUnitCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.UserOrgUnitUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
