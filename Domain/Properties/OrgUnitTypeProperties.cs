using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class OrgUnitTypeProperties : EntityTypeConfigurationBase<OrgUnitType>
{
    public override void Configure(EntityTypeBuilder<OrgUnitType> builder)
    {
        builder.ToTable("OrgUnitType");

        builder.Property(e => e.NameAr).HasMaxLength(150);
        builder.Property(e => e.NameEn).HasMaxLength(150);
        builder.HasData([
            new OrgUnitType{
                Id =1,
                NameAr= "Root",
                NameEn = "Root",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new OrgUnitType{
                Id =2,
                NameAr= "مؤسسة",
                NameEn = "مؤسسة",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            }
            ]);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.OrgUnitTypeCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.OrgUnitTypeUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
