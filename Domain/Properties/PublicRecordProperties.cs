using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class PublicRecordProperties : EntityTypeConfigurationBase<PublicRecord>
{
    public override void Configure(EntityTypeBuilder<PublicRecord> builder)
    {
        builder.ToTable("PublicRecord");

        builder.HasOne(d => d.Correspondence).WithMany(p => p.PublicRecords)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PublicRecord_Correspondences");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.PublicRecordCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.PublicRecordUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.CreatedBy).IsRequired(true);


        base.Configure(builder);
    }
}
