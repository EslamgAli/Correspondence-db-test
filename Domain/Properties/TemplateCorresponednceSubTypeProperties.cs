using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class TemplateCorresponednceSubTypeProperties : EntityTypeConfigurationBase<TemplateCorresponednceSubType>
{
    public override void Configure(EntityTypeBuilder<TemplateCorresponednceSubType> builder)
    {

        builder.HasOne(d => d.CorrespondenceSubType).WithMany(p => p.TemplateCorresponednceSubTypes)
            .HasForeignKey(d => d.CorrespondenceSubTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TemplateCorresponednceSubTypes_CorrespondenceTypes");

        builder.HasOne(d => d.Template).WithMany(p => p.TemplateCorresponednceSubTypes)
            .HasForeignKey(d => d.TemplateId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TemplateCorresponednceSubTypes_Templates");

        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.TemplateCorresponednceTypeCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.TemplateCorresponednceTypeUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
