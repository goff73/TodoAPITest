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
            var existingTodo = db.Todos.Where(x=>x.TodoId==todo.TodoId).First();
            existingTodo.TodoName=todo.TodoName;
            db.Update(existingTodo);
            db.SaveChanges();
            return todo;
        }

        public Todo DeleteItem(Todo todo)
        {
            var existingTodo = db.Todos.Where(x=>x.TodoId==todo.TodoId).First();
            db.Remove(existingTodo);
            db.SaveChanges();
            return todo;
        }

        public List<Todo> GetList()
        {
            return db.Todos.ToList();
        }
    }
}