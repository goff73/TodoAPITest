using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class Todo
    {
        public Todo()
        {
        }

        public int TodoId { get; set; }
        public string TodoName { get; set; }

        public List<Todo> Todos { get; } = new();

        public Todo(int todoId, string todoName)
        {
            TodoId = todoId;
            TodoName = todoName;
        }
    }
}