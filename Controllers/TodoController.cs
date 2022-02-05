using Microsoft.AspNetCore.Mvc;
using TodoAPI.Models;
using TodoAPI.Infrastructure;
using TodoAPI.Interfaces;

namespace TodoAPI.Controllers;



[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{

    private readonly ILogger<TodoController> _logger;
    private readonly IService<Todo> _service;

    public TodoController(ILogger<TodoController> logger,IService<Todo> service)
    {
        _service=service;
        _logger = logger;
    }

    [HttpGet(Name = "GetExistingTodos")]
    public List<Todo> GetExistingTodos()
    {
        var todo = _service.Get().Where(x=>x.Id==1).First();
        var itemsCount = todo.TodoItems.Count();
        var list = todo.TodoItems.ToList();
        return _service.Get().ToList();
    }

    [HttpPost(Name = "AddTodo")]
    public Todo AddTodo(Todo todo)
    {
         return _service.Add(todo);
    }

    [HttpPut(Name = "UpdateTodo")]
    public Todo UpdateTodo(Todo todo)
    {
        return _service.Update(todo);
    }

    [HttpDelete(Name = "DeleteTodo")]
    public bool DeleteTodo(int todoId)
    {
        _service.Delete(todoId);
        return true;
    }
}
