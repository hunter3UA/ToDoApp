namespace ToDo.Core.DbEntities;

public abstract class BaseEntityDb
{
    public Guid Id { get; set; }

    public bool IsRemoved { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
}
