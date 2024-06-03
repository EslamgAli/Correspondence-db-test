using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class CorrespondenceSubTypeProperties : EntityTypeConfigurationBase<CorrespondenceSubType>
{
    public override void Configure(EntityTypeBuilder<CorrespondenceSubType> builder)
    {
        builder.Property(e => e.NameAr).HasMaxLength(100);
        builder.Property(e => e.NameEn).HasMaxLength(100);

        builder.HasData([
            new CorrespondenceSubType
            {
                Id = 1,
                NameAr = "جزاء",
                NameEn = "جزاء",
                CorrespondenceTypeId = 5,
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new CorrespondenceSubType
            {
                Id = 2,
                NameAr = "خصم",
                NameEn = "خصم",
                CorrespondenceTypeId = 5,
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new CorrespondenceSubType
            {
                Id = 3,
                NameAr = "ترقيه",
                NameEn = "ترقيه",
                CorrespondenceTypeId = 5,
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            }
            ]);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.CorrespondenceSubTypeCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.CorrespondenceSubTypeUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
