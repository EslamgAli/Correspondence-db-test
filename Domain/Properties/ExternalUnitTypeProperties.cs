using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class ExternalUnitTypeProperties : EntityTypeConfigurationBase<ExternalUnitType>
{
    public override void Configure(EntityTypeBuilder<ExternalUnitType> builder)
    {
        builder.Property(e => e.NameAr).HasMaxLength(150);
        builder.Property(e => e.NameEn).HasMaxLength(150);

        builder.HasData([
            new ExternalUnitType{
                Id = 1,
                NameAr = "حكومي",
                NameEn = "حكومي",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new ExternalUnitType{
                Id = 2,
                NameAr = "خاص",
                NameEn = "خاص",
                CreatedAt= new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            }
            ]);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.ExternalUnitTypeCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.ExternalUnitTypeUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
