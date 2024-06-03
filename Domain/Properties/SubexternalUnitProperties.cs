using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class SubexternalUnitProperties : EntityTypeConfigurationBase<SubexternalUnit>
{
    public override void Configure(EntityTypeBuilder<SubexternalUnit> builder)
    {

        builder.HasData([
                new SubexternalUnit
                {
                    Id = 1,
                    NameAr= "ألامين العام",
                    NameEn= "ألامين العام",
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)

                },
                new SubexternalUnit
                {
                    Id = 2,
                    NameAr= "السجل العام",
                    NameEn= "السجل العام",
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)

                },
                new SubexternalUnit
                {
                    Id = 3,
                    NameAr= "السكرتارية",
                    NameEn= "السكرتارية",
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)

                }
            ]);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.SubexternalUnitCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.SubexternalUnitUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        base.Configure(builder);
    }
}
