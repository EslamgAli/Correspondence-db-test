using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class CorrespondencesOutboxProperties : EntityTypeConfigurationBase<CorrespondencesOutbox>
{
    public override void Configure(EntityTypeBuilder<CorrespondencesOutbox> builder)
    {
        builder.ToTable("CorrespondencesOutbox");

        builder.HasOne(d => d.Action).WithMany(p => p.CorrespondencesOutboxes)
            .HasForeignKey(d => d.ActionId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CorrespondencesOutbox_Actions");

        builder.HasOne(d => d.Correspondence).WithMany(p => p.CorrespondencesOutboxes)
            .HasForeignKey(d => d.CorrespondenceId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CorrespondencesOutbox_Correspondences");

        builder.HasOne(d => d.Procedure).WithMany(p => p.CorrespondencesOutboxes)
            .HasForeignKey(d => d.ProcedureId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CorrespondencesOutbox_Procedures");

        builder.HasOne(d => d.ToUserOrgUnit).WithMany(p => p.CorrespondencesOutboxToUserOrgUnits)
            .HasForeignKey(d => d.ToUserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CorrespondencesOutbox_UserOrgUnit1");

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.CorrespondencesOutboxUserOrgUnits)
            .HasForeignKey(d => d.UserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CorrespondencesOutbox_UserOrgUnit");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.CorrespondencesOutboxCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.CorrespondencesOutboxUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
