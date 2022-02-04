
using TodoAPI.Models;

public class TodoItem
{
    public string Title { get; set; }

    public string Description { get; set; }

    public virtual Todo Todo { get; set; }

    public int Id {get; set;}
}