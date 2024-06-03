using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Properties;

public class GroupProperties : EntityTypeConfigurationBase<Group>
{
    public override void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Name).HasMaxLength(150);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        builder.HasOne(d => d.UserOrgUnit).WithMany(p => p.Groups)
            .HasForeignKey(d => d.UserOrgUnitId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Groups_UserOrgUnit");



        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.GroupCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.GroupUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
