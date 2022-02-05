
using TodoAPI.Models;

public class TodoItem:ModelBase
{
    public string Title { get; set; }

    public string Description { get; set; }

    public virtual Todo Todo { get; set; }
}