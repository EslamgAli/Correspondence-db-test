using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class ProcedureProperties : EntityTypeConfigurationBase<Procedure>
{
    public override void Configure(EntityTypeBuilder<Procedure> builder)
    {
        builder.Property(e => e.NameAr).HasMaxLength(150);
        builder.Property(e => e.NameEn).HasMaxLength(150);

        builder.HasData([
            new Procedure {
                Id= 1,
                NameAr="توجيه",
                NameEn= "توجيه",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Procedure{
                Id= 2,
                NameAr="تصعيد",
                NameEn= "تصعيد",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Procedure{
                Id= 3,
                NameAr="اسناد",
                NameEn= "اسناد",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Procedure{
                Id= 4,
                NameAr="الغاء",
                NameEn= "الغاء",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Procedure{
                Id= 5,
                NameAr="تصديق",
                NameEn= "تصديق",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            },
            new Procedure{
                Id= 6,
                NameAr="ارسال للموافقة",
                NameEn= "ارسال للموافقة",
                CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032)
            }
            ]);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.ProcedureCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.ProcedureUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
