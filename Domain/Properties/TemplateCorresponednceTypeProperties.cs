using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class TemplateCorresponednceTypeProperties : EntityTypeConfigurationBase<TemplateCorresponednceType>
{
    public override void Configure(EntityTypeBuilder<TemplateCorresponednceType> builder)
    {

        builder.HasOne(d => d.CorresponednceType).WithMany(p => p.TemplateCorresponednceTypes)
            .HasForeignKey(d => d.CorresponednceTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TemplateCorresponednceTypes_CorrespondenceTypes");
        /*
                builder.HasOne(d => d.DecisionType).WithMany(p => p.TemplateCorresponednceTypes)
                    .HasForeignKey(d => d.DecisionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateCorresponednceTypes_DecisionTypes");*/

        builder.HasOne(d => d.Template).WithMany(p => p.TemplateCorresponednceTypes)
            .HasForeignKey(d => d.TemplateId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TemplateCorresponednceTypes_Templates");

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
