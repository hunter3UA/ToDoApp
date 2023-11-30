namespace ToDo.Core.DbEntities;

public class TaskDb : BaseEntityDb
{
    public required string Title { get; set; }

    public TaskStatus Status { get; set; }

    public DateTimeOffset? StartTime { get; set; }
}
