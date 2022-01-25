using TodoAPI.Models;
using TodoAPI.Interfaces;

namespace TodoAPI.Infrastructure
{
    public class TodoListRepository : ITodoListRepository
    {
        TodoAPI.Models.ToDoContext db= new TodoAPI.Models.ToDoContext();
        public Todo AddTodo(Todo todo)
        {
            db.Add(todo);
            db.SaveChanges();
            return todo;
        }

        public Todo UpdateTodo(Todo todo)
        {
            var existingTodo = db.Todos.Where(x=>x.TodoId==todo.TodoId).First();
            existingTodo.TodoName=todo.TodoName;
            db.Update(existingTodo);
            db.SaveChanges();
            return todo;
        }

        public Todo DeleteTodo(Todo todo)
        {
            var existingTodo = db.Todos.Where(x=>x.TodoId==todo.TodoId).First();
            db.Remove(existingTodo);
            db.SaveChanges();
            return todo;
        }

        public List<Todo> GetTodos()
        {
            return db.Todos.ToList();
        }
    }
}