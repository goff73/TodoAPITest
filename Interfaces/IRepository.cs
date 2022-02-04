using TodoAPI.Models;

namespace TodoAPI.Interfaces
{
    public interface IRepository<T>
    {
        T AddItem(T item);
        T UpdateItem(T item);
        T DeleteItem(T item);
        IEnumerable<T> GetList();
    }
}