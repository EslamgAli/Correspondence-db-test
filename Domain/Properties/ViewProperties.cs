using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class ViewProperties : EntityTypeConfigurationBase<View>
{
    public override void Configure(EntityTypeBuilder<View> builder)
    {
        builder.HasOne(d => d.Correspondence).WithMany(p => p.Views)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Views_Correspondences");

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.Views)
            .HasForeignKey(d => d.UserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Views_UserOrgUnit");


        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.ViewCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.ViewUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.CreatedBy).IsRequired(true);


        base.Configure(builder);
    }
}
