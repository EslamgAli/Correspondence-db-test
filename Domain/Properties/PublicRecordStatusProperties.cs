using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class PublicRecordStatusProperties : EntityTypeConfigurationBase<PublicRecordStatus>
{
    public override void Configure(EntityTypeBuilder<PublicRecordStatus> builder)
    {

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.PublicRecordStatusCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.PublicRecordStatusUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
