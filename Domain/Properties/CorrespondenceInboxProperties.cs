using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class CorrespondenceInboxProperties : EntityTypeConfigurationBase<CorrespondenceInbox>
{
    public override void Configure(EntityTypeBuilder<CorrespondenceInbox> builder)
    {
        builder.ToTable("CorrespondenceInbox");

            builder.HasOne(d => d.Action).WithMany(p => p.CorrespondenceInboxes)
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("FK_CorrespondenceInbox_Actions");

            builder.HasOne(d => d.Correspondence).WithMany(p => p.CorrespondenceInboxes)
                .HasForeignKey(d => d.CorrespondenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrespondenceInbox_Correspondences");

            builder.HasOne(d => d.FromUserOrgUnit).WithMany(p => p.CorrespondenceInboxFromUserOrgUnits)
                .HasForeignKey(d => d.FromUserOrgUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrespondenceInbox_UserOrgUnit1");

            builder.HasOne(d => d.Procedure).WithMany(p => p.CorrespondenceInboxes)
                .HasForeignKey(d => d.ProcedureId)
                .HasConstraintName("FK_CorrespondenceInbox_Procedures");

            builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.CorrespondenceInboxUserOrgUnits)
                .HasForeignKey(d => d.UserOrgUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorrespondenceInbox_UserOrgUnit");


        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.CorrespondenceInboxCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.CorrespondenceInboxUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
