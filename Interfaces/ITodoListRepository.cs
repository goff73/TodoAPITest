using TodoAPI.Models;

namespace TodoAPI.Interfaces
{
    public interface ITodoListRepository
    {
        Todo AddTodo(Todo todo);
        Todo UpdateTodo(Todo todo);
        Todo DeleteTodo(Todo todo);
        List<Todo> GetTodos();
    }
}
