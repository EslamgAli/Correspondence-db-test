
using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;
public class OrgUnitProperties : EntityTypeConfigurationBase<OrgUnit>
{
    public override void Configure(EntityTypeBuilder<OrgUnit> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_OrgUnit");

        builder.Property(e => e.Name).HasMaxLength(150);

        builder.HasOne(d => d.OrgUnitType).WithMany(p => p.OrgUnits)
            .HasForeignKey(d => d.OrgUnitTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_OrgUnits_OrgUnitType");

        builder.HasData([
            new OrgUnit {
                Id = 1,
                Name = "الهيكل التنظيمى",
                Hid = HierarchyId.Parse("/0/"),
                Lvl = 0,
                OrgUnitTypeId=1,
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new OrgUnit {
                Id = 2,
                Name = "الامانه العامه للاوقاف",
                Hid = HierarchyId.Parse("/0/"),
                Lvl = 1,
                OrgUnitTypeId = 2,
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            }
            ]);


        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.OrgUnitCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.OrgUnitUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
