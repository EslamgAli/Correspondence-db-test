
using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class TemplateProperties : EntityTypeConfigurationBase<Template>
{
    public override void Configure(EntityTypeBuilder<Template> builder)
    {
        builder.Property(e => e.NameAr).HasMaxLength(50);
        builder.Property(e => e.NameEn).HasMaxLength(50);
        builder.Property(e => e.TemplatePath).HasMaxLength(100);

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.TemplateCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.TemplateUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
