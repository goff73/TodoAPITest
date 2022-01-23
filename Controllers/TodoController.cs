using Microsoft.AspNetCore.Mvc;

namespace TodoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{

    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetExistingTodos")]
    public string GetExistingTodos()
    {
        using (var db = new Models.ToDoContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");
                return String.Join(",",db.Todos.Select(x=>x.TodoName));
            }
    }

    [HttpPost(Name = "AddTodo")]
    public string AddTodo(string theTodoItem)
    {
        using (var db = new Models.ToDoContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");
                
                // Create
                Console.WriteLine("Inserting a new item in todo list");
                db.Add(new Models.Todo {TodoName = theTodoItem});
                db.SaveChanges();

                //show new list
                return String.Join(",",db.Todos.Select(x=> $"ID: {x.TodoId} Name: {x.TodoName}"));
            }
    }

    [HttpPut(Name = "UpdateTodo")]
    public string GetExistingTodos(int todoId, string description)
    {
        using (var db = new Models.ToDoContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");
                
                var existingTodo = db.Todos.Where(x=>x.TodoId==todoId).First();

                existingTodo.TodoName=description;

                db.Update(existingTodo);
                db.SaveChanges();

                //show new list
                return String.Join(",",db.Todos.Select(x=> $"ID: {x.TodoId} Name: {x.TodoName}"));
            }
    }

    [HttpDelete(Name = "DeleteTodo")]
    public string DeleteTodo(int todoId)
    {
        using (var db = new Models.ToDoContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");
                
                // Delete
                Console.WriteLine("Delete the todo");
                var existingTodo = db.Todos.Where(x=>x.TodoId==todoId).First();
                db.Remove(existingTodo);
                db.SaveChanges();
                
                //show new list
                return String.Join(",",db.Todos.Select(x=> $"ID: {x.TodoId} Name: {x.TodoName}"));
            }
    }
}
