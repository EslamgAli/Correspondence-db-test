using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class SentToExternalUnitProperties : EntityTypeConfigurationBase<SentToExternalUnit>
{
    public override void Configure(EntityTypeBuilder<SentToExternalUnit> builder)
    {
        builder.HasOne(d => d.Correspodence).WithMany(p => p.SentToExternalUnits)
            .HasForeignKey(d => d.CorrespodenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SentToExternalUnits_Correspondences");

        builder.HasOne(d => d.ExternalUnit).WithMany(p => p.SentToExternalUnits)
            .HasForeignKey(d => d.ExternalUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SentToExternalUnits_ExternalUnits");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.SentToExternalUnitCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.SentToExternalUnitUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
