using TodoAPI.Models;
using TodoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Infrastructure
{
    public class TodoItemRepository : RepositoryBase<TodoItem>
    {
        public TodoItemRepository(ToDoContext toDoContext):base((DbContext)toDoContext)
        {
            
        }
    }
}