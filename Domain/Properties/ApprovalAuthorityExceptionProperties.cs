
using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class ApprovalAuthorityExceptionProperties : EntityTypeConfigurationBase<ApprovalAuthorityException>
{
    public override void Configure(EntityTypeBuilder<ApprovalAuthorityException> builder)
    {
        builder.HasOne(d => d.OrgUnit).WithMany(p => p.ApprovalAuthorityExceptions)
            .HasForeignKey(d => d.OrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ApprovalAuthorityExceptions_OrgUnits");

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.ApprovalAuthorityExceptions)
            .HasForeignKey(d => d.UserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ApprovalAuthorityExceptions_UserOrgUnit");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.ApprovalAuthorityExceptionCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.ApprovalAuthorityExceptionUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);



        base.Configure(builder);
    }
}
