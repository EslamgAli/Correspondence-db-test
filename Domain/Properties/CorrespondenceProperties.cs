using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class CorrespondenceProperties : EntityTypeConfigurationBase<Correspondence, Guid>
{
    public override void Configure(EntityTypeBuilder<Correspondence> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.FilePath).HasMaxLength(100);
        builder.Property(e => e.Comment).HasMaxLength(300);
        builder.Property(e => e.RefNumber).HasMaxLength(25);
        builder.Property(e => e.Subject).HasMaxLength(150);

        /* builder.HasOne(e => e.CorrespondenceType)
             .WithMany(e => e.Correspondences)
             .HasForeignKey(e => e.CorrespondenceTypeId)
             .OnDelete(DeleteBehavior.Restrict);*/

        builder.HasOne(e => e.CorrespondenceSubType)
            .WithMany(e => e.Correspondences)
            .HasForeignKey(e => e.CorrespondenceSubTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Workflow)
            .WithMany(e => e.Correspondences)
            .HasForeignKey(e => e.WorkflowId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Template)
            .WithMany(e => e.Correspondences)
            .HasForeignKey(e => e.TemplateId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.ExternalUnit)
            .WithMany(e => e.Correspondences)
            .HasForeignKey(e => e.ExternalUnitId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
            .HasForeignKey(d => d.ParentId)
            .HasConstraintName("FK_Correspondences_Correspondences");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.CorrespondenceCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.CorrespondenceUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
