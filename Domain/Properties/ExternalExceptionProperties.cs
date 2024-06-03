using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Domain.Properties
{
    public class ExternalExceptionProperties : EntityTypeConfigurationBase<ExternalException>
    {
        public override void Configure(EntityTypeBuilder<ExternalException> builder)
        {
            builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.ExternalExceptionCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.UpdatedByUser)
                .WithMany(d => d.ExternalExceptionUpdate)
                .HasForeignKey(e => e.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
