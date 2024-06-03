using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties
{
    public class CorrespondenceActionsProperties : EntityTypeConfigurationBase<CorrespondenceAction>
    {
        public override void Configure(EntityTypeBuilder<CorrespondenceAction> builder)
        {
            builder.Property(e => e.ArabicName).HasMaxLength(50);
            builder.Property(e => e.EnglishName).HasMaxLength(50);

            builder.HasOne(d => d.CreatedByUser)
          .WithMany(p => p.CorrespondenceActionsCreate)
          .HasForeignKey(e => e.CreatedBy)
          .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.UpdatedByUser)
                   .WithMany(d => d.CorrespondenceActionsUpdate)
                   .HasForeignKey(e => e.UpdatedBy)
                   .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
        //CorrespondenceActions
    }
}
