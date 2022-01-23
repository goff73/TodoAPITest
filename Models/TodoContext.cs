using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class ToDoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public string DbPath { get; }

        public ToDoContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "todo.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class Todo
    {
        public int TodoId { get; set; }
        public string TodoName { get; set; }

        public List<Todo> Todos { get; } = new();
    }
}