using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class Todo
    {
        public virtual ICollection<TodoItem> TodoItems {get; set;}
        public int Id { get; set; }
        public string TodoName { get; set; }
    }
}