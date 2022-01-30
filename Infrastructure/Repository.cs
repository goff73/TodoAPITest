using TodoAPI.Models;
using TodoAPI.Interfaces;
using System.Reflection;

namespace TodoAPI.Infrastructure
{
    public class Repository<T> : IRepository<T>
    {

        TodoAPI.Models.ToDoContext db= new TodoAPI.Models.ToDoContext();
        public Repository()
        {
            
        }

        public T AddItem(T item)
        {
            db.Add(item);
            db.SaveChanges();
            return item;
        }


        public T UpdateItem(T item)
        {
            db.Update(item);
            db.SaveChanges();
            return item;
        }

        public T DeleteItem(T item)
        {
            db.Remove(item);
            db.SaveChanges();
            return item;
        }

        public List<T> GetList()
        {
             return db.Todos.Select(x=>x).ToList().Cast<T>().ToList(); 
        }
        
    }
}