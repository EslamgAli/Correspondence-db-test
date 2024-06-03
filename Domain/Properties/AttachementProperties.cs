
using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class AttachementProperties : EntityTypeConfigurationBase<Attachement>
{
    public override void Configure(EntityTypeBuilder<Attachement> builder)
    {
        builder.Property(e => e.Path).HasMaxLength(100);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        builder.HasOne(d => d.AttachementType).WithMany(p => p.Attachements)
            .HasForeignKey(d => d.AttachementTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Attachements_AttachementTypes");

        builder.HasOne(d => d.Correspondence).WithMany(p => p.Attachements)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Attachements_Correspondences");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.AttachementCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.AttachementUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
