using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties
{
    public class TaskActionsProperties:EntityTypeConfigurationBase<TaskAction>
    {
        public override void Configure(EntityTypeBuilder<TaskAction> builder)
        {
            builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.TaskActionsCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.UpdatedByUser)
                .WithMany(d => d.TaskActionsUpdate)
                .HasForeignKey(e => e.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
            //TaskActions
        }
}
