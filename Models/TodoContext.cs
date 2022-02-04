using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;

namespace TodoAPI.Models
{
    public class ToDoContext : DbContext
    {
        public DbSet<Todo> Todo { get; set; }
        public DbSet<TodoItem> TodoItem { get; set; }

        public string DbPath { get; }

        public ToDoContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData; 
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "todo1.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseLazyLoadingProxies()
        .UseSqlite($"Data Source={DbPath}");
    }
}
