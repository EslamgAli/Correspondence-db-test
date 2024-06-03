using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class ExternalUnitProperties : EntityTypeConfigurationBase<ExternalUnit>
{
    public override void Configure(EntityTypeBuilder<ExternalUnit> builder)
    {
        builder.Property(e => e.Address).HasMaxLength(250);
        builder.Property(e => e.Fax).HasMaxLength(25);
        builder.Property(e => e.Mail).HasMaxLength(50);
        builder.Property(e => e.NameAr).HasMaxLength(150);
        builder.Property(e => e.NameEn).HasMaxLength(150);
        builder.Property(e => e.Telephone).HasMaxLength(25);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        builder.HasOne(e => e.SubexternalUnit).WithMany(e => e.ExternalUnits)
            .HasForeignKey(e => e.SubexternalUnitId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.ExternalUnitType).WithMany(p => p.ExternalUnits)
            .HasForeignKey(d => d.ExternalUnitTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ExternalUnits_ExternalUnitTypes");


        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.ExternalUnitCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.ExternalUnitUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
