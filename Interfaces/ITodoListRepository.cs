using TodoAPI.Models;

namespace TodoAPI.Interfaces
{
    public interface ITodoListRepository:IRepository<Todo>
    {
        //Here you could add specific methods
        //IEnumerable<Todo> GetTodoByTodoListID(int todoListId);
    }
}