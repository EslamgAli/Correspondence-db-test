using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Properties
{
    public class CorrespondenceTypeProperties : EntityTypeConfigurationBase<CorrespondenceType>
    {
        public override void Configure(EntityTypeBuilder<CorrespondenceType> builder)
        {
            builder.Property(e => e.NameAr).HasMaxLength(50);
            builder.Property(e => e.NameEn).HasMaxLength(50);

            builder.HasOne(d => d.OrgUnitResponsibility).WithMany(p => p.CorrespondenceTypes)
            .HasForeignKey(d => d.OrgUnitResponsibilityId);

            builder.HasData([
                new CorrespondenceType {
                    Id = 1,
                    NameAr = "وارد داخلي",
                    NameEn = "وارد داخلي",
                    IsExternalUnits = false,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
                },
                new CorrespondenceType {
                    Id= 2,
                    NameAr = "صادر داخلي",
                    NameEn = "صادر داخلي",
                    IsExternalUnits = false,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
                },
                new CorrespondenceType {
                    Id = 3,
                    NameAr = "وارد خارجي",
                    NameEn = "وارد خارجي",
                    IsExternalUnits = true,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
                },
                new CorrespondenceType {
                    Id = 4,
                    NameAr = "صادر خارجي",
                    NameEn = "صادر خارجي",
                    IsExternalUnits = true,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
                },
                new CorrespondenceType {
                    Id = 5,
                    NameAr = "قرارت",
                    NameEn = "قرارت",
                    IsExternalUnits = false,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
                },
                new CorrespondenceType {
                    Id = 6,
                    NameAr = "تعاميم",
                    NameEn = "تعاميم",
                    IsExternalUnits = false,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
                },
                new CorrespondenceType {
                    Id = 7,
                    NameAr = "سجل عام",
                    NameEn = "سجل عام",
                    IsExternalUnits = false,
                    CreatedAt = new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032),
                }
                ]);

            builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.CorrespondenceTypeCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.UpdatedByUser)
                .WithMany(d => d.CorrespondenceTypeUpdate)
                .HasForeignKey(e => e.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);


            base.Configure(builder);
        }
    }
}
