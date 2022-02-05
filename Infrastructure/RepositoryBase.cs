using TodoAPI.Models;
using TodoAPI.Interfaces;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T:ModelBase
    {

        private DbContext _dbContext;
        private DbSet<T> _dbSet;
        public RepositoryBase(DbContext dbContext)
        {
            _dbContext=dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public T Add(T item)
        {
            _dbSet.Add(item);
            _dbContext.SaveChanges();
            return item;
        }


        public T Update(T item)
        {
            _dbSet.Update(item);
            _dbContext.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            var item = Get(id);
            _dbSet.Remove(item);
            _dbContext.SaveChanges();
        }
        public T Get(int id)
        {
            return _dbSet.FirstOrDefault(x=>x.Id==id);
        }
        public IEnumerable<T> Get(Func<T,bool> filter)
        {
            return _dbSet.Where(filter);
        }

        public IEnumerable<T> Get()
        {
             return _dbSet;
        }
        
    }
}