
using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class DraftProperties : EntityTypeConfigurationBase<Draft>
{
    public override void Configure(EntityTypeBuilder<Draft> builder)
    {
        builder.ToTable("Draft");

        builder.HasOne(d => d.Correspondence).WithMany(p => p.Drafts)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Draft_Correspondences");

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.Drafts)
            .HasForeignKey(d => d.UserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Draft_UserOrgUnit");


        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.DraftCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.DraftUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
