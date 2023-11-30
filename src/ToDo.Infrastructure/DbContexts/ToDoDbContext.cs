using Microsoft.EntityFrameworkCore;
using ToDo.Core.DbEntities;

namespace ToDo.Infrastructure.DbContexts;

public class ToDoDbContext: DbContext
{
    public DbSet<TaskDb> Tasks { get; set; }

    public ToDoDbContext(DbContextOptions dbOptions) : base(dbOptions)
    {

    }
}
