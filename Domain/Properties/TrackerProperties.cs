using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class TrackerProperties : EntityTypeConfigurationBase<Tracker>
{
    public override void Configure(EntityTypeBuilder<Tracker> builder)
    {
        builder.Property(e => e.Notes).HasMaxLength(150);

        builder.HasOne(d => d.Action).WithMany(p => p.Trackers)
            .HasForeignKey(d => d.ActionId)
            .HasConstraintName("FK_Trackers_Actions");

        builder.HasOne(d => d.Correspondence).WithMany(p => p.Trackers)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Trackers_Correspondences");

        builder.HasOne(d => d.FromUserOrgUnit).WithMany(p => p.TrackerFromUserOrgUnits)
            .HasForeignKey(d => d.FromUserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Trackers_UserOrgUnit");

        builder.HasOne(d => d.ToUserOrgUnit).WithMany(p => p.TrackerToUserOrgUnits)
            .HasForeignKey(d => d.ToUserOrgUnitId)
            .HasConstraintName("FK_Trackers_UserOrgUnit1");

        builder.HasOne(d => d.TrackerStatus).WithMany(p => p.Trackers)
            .HasForeignKey(d => d.TrackerStatusId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Trackers_TrackerStatus");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.TrackerCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.TrackerUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
