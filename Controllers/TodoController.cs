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
    private IRepository<Todo> _repository;
    //private ITodoListRepository _todoListRepository;

    public TodoController(ILogger<TodoController> logger,IRepository<Todo> repository)
    {
        _repository=repository;
        //_todoListRepository=todoListRepository;
        _logger = logger;
    }

    [HttpGet(Name = "GetExistingTodos")]
    public List<Todo> GetExistingTodos()
    {
        return _repository.GetList();
    }

    [HttpPost(Name = "AddTodo")]
    public Todo AddTodo(Todo todo)
    {
        return _repository.AddItem(todo);
    }

    [HttpPut(Name = "UpdateTodo")]
    public Todo UpdateTodo(Todo todo)
    {
        return _repository.UpdateItem(todo);
    }

    [HttpDelete(Name = "DeleteTodo")]
    public Todo DeleteTodo(Todo todo)
    {
        return _repository.DeleteItem(todo);
    }
}
