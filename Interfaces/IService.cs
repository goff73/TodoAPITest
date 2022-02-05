using TodoAPI.Models;

namespace TodoAPI.Interfaces
{
    public interface IService<T>
    {
        T Add(T item);
        T Update(T item);
        void Delete(int id);
        T Get(int id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T,bool> filter);
    }
}