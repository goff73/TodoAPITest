using TodoAPI.Interfaces;
using TodoAPI.Infrastructure;
using TodoAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddScoped<ToDoContext>(sp=>new ToDoContext());
builder.Services.AddScoped<IRepository<Todo>,TodoListRepository>();
builder.Services.AddScoped<IRepository<TodoItem>,TodoItemRepository>();
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
