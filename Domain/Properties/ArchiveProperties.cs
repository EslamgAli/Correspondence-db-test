
using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class ArchiveProperties : EntityTypeConfigurationBase<Archive>
{
    public override void Configure(EntityTypeBuilder<Archive> builder)
    {
        builder.ToTable("Archive");
        builder.Property(e => e.CreatedBy).IsRequired(true);

        builder.HasOne(d => d.Correspondence).WithMany(p => p.Archives)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Archive_Correspondences");

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.Archives)
            .HasForeignKey(d => d.UserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Archive_UserOrgUnit");


        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.ArchiveCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.ArchiveUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
