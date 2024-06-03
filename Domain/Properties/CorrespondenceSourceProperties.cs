using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties
{
    public class CorrespondenceSourceProperties : EntityTypeConfigurationBase<CorrespondenceSource>
    {
        public override void Configure(EntityTypeBuilder<CorrespondenceSource> builder)
        {
            builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.CorrespondenceSourceCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.UpdatedByUser)
                .WithMany(d => d.CorrespondenceSourceUpdate)
                .HasForeignKey(e => e.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
