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
    private ITodoListRepository _repository;

    public TodoController(ILogger<TodoController> logger,ITodoListRepository repository)
    {
        _repository=repository;
        _logger = logger;
    }

    [HttpGet(Name = "GetExistingTodos")]
    public List<Todo> GetExistingTodos()
    {
        return _repository.GetTodos();
    }

    [HttpPost(Name = "AddTodo")]
    public Todo AddTodo(Todo todo)
    {
        return _repository.AddTodo(todo);
    }

    [HttpPut(Name = "UpdateTodo")]
    public Todo UpdateTodo(Todo todo)
    {
        return _repository.UpdateTodo(todo);
    }

    [HttpDelete(Name = "DeleteTodo")]
    public Todo DeleteTodo(Todo todo)
    {
        return _repository.DeleteTodo(todo);
    }
}
