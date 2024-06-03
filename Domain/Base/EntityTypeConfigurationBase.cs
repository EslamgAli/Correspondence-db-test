using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Domain.Base;

public class EntityTypeConfigurationBase<Entity, TKey> : IEntityTypeConfiguration<Entity>
    where Entity : EntityBase<TKey>
{
    public virtual void Configure(EntityTypeBuilder<Entity> builder)
    {
        builder.Property(e => e.CreatedAt).HasColumnType("datetime");
        builder.Property(e => e.UpdatedAt).HasColumnType("datetime");

    }

    
}


public abstract class EntityTypeConfigurationBase<Entity> : EntityTypeConfigurationBase<Entity, int>
    where Entity : EntityBase;
