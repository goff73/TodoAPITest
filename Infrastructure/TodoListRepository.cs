using TodoAPI.Models;
using TodoAPI.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Infrastructure
{    
    public class TodoListRepository : RepositoryBase<Todo>
    {
        public TodoListRepository(ToDoContext toDoContext):base((DbContext)toDoContext)
        {
            
        }
    }
}