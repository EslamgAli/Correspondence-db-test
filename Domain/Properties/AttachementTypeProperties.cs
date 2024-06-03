using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

internal class AttachementTypeProperties : EntityTypeConfigurationBase<AttachementType>
{
    public override void Configure(EntityTypeBuilder<AttachementType> builder)
    {
        builder.Property(e => e.CreatedAt).HasColumnType("datetime");
        builder.Property(e => e.NameAr).HasMaxLength(50);
        builder.Property(e => e.NameEn).HasMaxLength(50);
        builder.Property(e => e.UpdatedAt).HasColumnType("datetime");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.AttachementTypeCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.AttachementTypeUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData([
            new AttachementType {
                Id = 1,
                NameAr = "ملف نصي",
                NameEn = "Word file",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
            },
            new AttachementType {
                Id = 2,
                NameAr = "ملف PDF",
                NameEn = "PDF file",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
            }]);

        base.Configure(builder);
    }
}
