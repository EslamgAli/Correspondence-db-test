using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class SentToOrgUnitProperties : EntityTypeConfigurationBase<SentToOrgUnit>
{
    public override void Configure(EntityTypeBuilder<SentToOrgUnit> builder)
    {
        builder.ToTable("SentToOrgUnit");

        builder.HasOne(d => d.Correspondence).WithMany(p => p.SentToOrgUnits)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SentToOrgUnit_Correspondences");

        builder.HasOne(d => d.OrgUnit).WithMany(p => p.SentToOrgUnits)
            .HasForeignKey(d => d.OrgUnitid)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SentToOrgUnit_OrgUnits");


        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.SentToOrgUnitCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.SentToOrgUnitUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
