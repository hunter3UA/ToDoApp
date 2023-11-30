using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Core.DbEntities;

namespace ToDo.Infrastructure.Configurations;
public class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : BaseEntityDb
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.IsRemoved).HasDefaultValue(false);
        builder.Property(entity => entity.CreatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
    }
}