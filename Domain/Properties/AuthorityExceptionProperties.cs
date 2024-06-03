
using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class AuthorityExceptionProperties : EntityTypeConfigurationBase<AuthorityException>
{
    public override void Configure(EntityTypeBuilder<AuthorityException> builder)
    {
        builder.HasOne(d => d.OrgUnit).WithMany(p => p.AuthorityExceptions)
            .HasForeignKey(d => d.OrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_AuthorityExceptions_OrgUnits");

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.AuthorityExceptions)
            .HasForeignKey(d => d.UserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_AuthorityExceptions_UserOrgUnit");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.AuthorityExceptionCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.AuthorityExceptionUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
