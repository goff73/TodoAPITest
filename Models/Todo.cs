using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string TodoName { get; set; }

        public List<Todo> Todos { get; } = new();
    }
}