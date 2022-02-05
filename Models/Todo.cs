using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class Todo:ModelBase
    {
        public virtual ICollection<TodoItem> TodoItems {get; set;}
        public string TodoName { get; set; }
    }
}