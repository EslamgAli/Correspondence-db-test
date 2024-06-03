using Domain.Base;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Delegate = Domain.Models.Delegate;

namespace Domain.Properties;

public class DelegateProperties : EntityTypeConfigurationBase<Delegate>
{
    public override void Configure(EntityTypeBuilder<Delegate> builder)
    {        
        builder.HasOne(d => d.DelegateFromNavigation).WithMany(p => p.Delegates)
            .HasForeignKey(d => d.DelegateFrom)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_Delegates_UserOrgUnit");


        builder.HasOne(d => d.UserOrgUnit).WithOne(p => p.Delegate)
            .HasForeignKey<UserOrgUnit>(d => d.DelegateId)
            .HasConstraintName("FK_UserOrgUnit_Delegate");



        builder.HasOne(d => d.CreatedByUser)
            .WithMany(p => p.DelegateCreate)
            .HasForeignKey(e => e.CreatedBy)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.UpdatedByUser)
            .WithMany(d => d.DelegateUpdate)
            .HasForeignKey(e => e.UpdatedBy)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedBy).IsRequired(true);

        base.Configure(builder);
    }
}
