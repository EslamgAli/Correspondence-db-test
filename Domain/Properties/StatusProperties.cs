using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class StatusProperties : EntityTypeConfigurationBase<Status>
{
    public override void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.Property(e => e.NameAr).HasMaxLength(50);
        builder.Property(e => e.NameEn).HasMaxLength(50);

        builder.HasData([
            new Status
            {
                Id = 1,
                NameAr = "ارسال للموافقة",
                NameEn = "ارسال للموافقة",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Status
            {
                Id = 2,
                NameAr = "اعادة",
                NameEn = "اعادة",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Status
            {
                Id = 3,
                NameAr = "مرفوض",
                NameEn = "مرفوض",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Status
            {
                Id = 4,
                NameAr = "مؤجلة",
                NameEn = "مؤجلة",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            }
            ,
            new Status
            {
                Id = 5,
                NameAr = "جديد",
                NameEn = "جديد",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Status
            {
                Id = 6,
                NameAr = "قيد التنفيذ",
                NameEn = "قيد التنفيذ",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Status
            {
                Id = 7,
                NameAr = "جارى التنفيذ",
                NameEn = "جارى التنفيذ",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Status
            {
                Id = 8,
                NameAr = "مسودة",
                NameEn = "مسودة",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Status
            {
                Id = 9,
                NameAr = "حذف",
                NameEn = "حذف",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Status
            {
                Id = 10,
                NameAr = "متأخره",
                NameEn = "متأخره",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            }
        ]);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.StatusCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.StatusUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        base.Configure(builder);
    }
}
