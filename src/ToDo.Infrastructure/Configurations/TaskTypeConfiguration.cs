using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDo.Core.Constants;
using ToDo.Core.DbEntities;
using ToDo.Core.Enums;

namespace ToDo.Infrastructure.Configurations;
public class TaskTypeConfiguration : BaseEntityTypeConfiguration<TaskDb>
{
    public override void Configure(EntityTypeBuilder<TaskDb> builder)
    {
        base.Configure(builder);

        builder.Property(entity => entity.Title)
            .HasMaxLength(GlobalConstants.TaskConstants.MaxTitleSize)
            .IsRequired();

        builder.Property(entity => entity.Status).HasDefaultValue(UserTaskStatus.Active);
    }
}