using TodoAPI.Models;
using TodoAPI.Interfaces;

namespace TodoAPI.Infrastructure
{
    public class TodoListRepository : Repository<Todo>
    {
        public TodoListRepository()
        {
            
        }
        TodoAPI.Models.ToDoContext db= new TodoAPI.Models.ToDoContext();
        public Todo AddItem(Todo todo)
        {
            db.Add(todo);
            db.SaveChanges();
            return todo;
        }

        public Todo UpdateItem(Todo todo)
        {
            return todo;
        }

        public Todo DeleteItem(Todo todo)
        {
            return todo;
        }

        public IEnumerable<Todo> GetList()
        {
            return db.Todo;
        }
    }
}