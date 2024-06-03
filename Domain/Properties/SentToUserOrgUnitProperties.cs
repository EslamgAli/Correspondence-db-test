using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class SentToUserOrgUnitProperties : EntityTypeConfigurationBase<SentToUserOrgUnit>
{
    public override void Configure(EntityTypeBuilder<SentToUserOrgUnit> builder)
    {
        builder.HasOne(d => d.Correspondence).WithMany(p => p.SentToUserOrgUnits)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SentToUserOrgUnits_Correspondences");

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.SentToUserOrgUnits)
            .HasForeignKey(d => d.UserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SentToUserOrgUnits_UserOrgUnit");



        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.SentToUserOrgUnitCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.SentToUserOrgUnitUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
