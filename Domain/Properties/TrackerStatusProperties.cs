using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class TrackerStatusProperties : EntityTypeConfigurationBase<TrackerStatus>
{
    public override void Configure(EntityTypeBuilder<TrackerStatus> builder)
    {
        builder.ToTable("TrackerStatus");

        builder.Property(e => e.NameAr).HasMaxLength(50);
        builder.Property(e => e.NameEn).HasMaxLength(50);

        builder.HasData([
            new TrackerStatus{
                Id = 1,
                NameAr= "انشاء",
                NameEn= "انشاء",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)

            },
            new TrackerStatus{
                Id = 2,
                NameAr= "ارسال للموافقة",
                NameEn= "ارسال للموافقة",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new TrackerStatus{
                Id = 3,
                NameAr= "تصديق",
                NameEn= "تصديق",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new TrackerStatus{
                Id = 4,
                NameAr= "تحرير",
                NameEn= "تحرير",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new TrackerStatus{
                Id = 5,
                NameAr= "تعديل",
                NameEn= "تعديل",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new TrackerStatus{
                Id = 6,
                NameAr= "المصادقة",
                NameEn= "المصادقة",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new TrackerStatus{
                Id = 7,
                NameAr= "جديد",
                NameEn= "جديد",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new TrackerStatus{
                Id = 8,
                NameAr= "تحويل لاجراء اللازم",
                NameEn= "تحويل لاجراء اللازم",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            }
            ]);
        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.TrackerStatusCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.TrackerStatusUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        base.Configure(builder);
    }
}
