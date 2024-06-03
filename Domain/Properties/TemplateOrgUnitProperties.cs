using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class TemplateOrgUnitProperties : EntityTypeConfigurationBase<TemplateOrgUnit>
{
    public override void Configure(EntityTypeBuilder<TemplateOrgUnit> builder)
    {

        builder.HasOne(d => d.OrgUnit).WithMany(p => p.TemplateOrgUnits)
            .HasForeignKey(d => d.OrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TemplateOrgUnits_UserOrgUnit");

        builder.HasOne(d => d.Template).WithMany(p => p.TemplateOrgUnits)
            .HasForeignKey(d => d.TemplateId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TemplateOrgUnits_Templates");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.TemplateOrgUnitCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.TemplateOrgUnitUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
