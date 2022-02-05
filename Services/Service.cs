using TodoAPI.Interfaces;
using TodoAPI.Models;

//Review.
public class Service<T>:IService<T> where T:ModelBase
{
    private readonly IRepository<T> _repo;
    public Service(IRepository<T> repo)
    {
        _repo=repo;
    }

    public T Add(T item)
    {
        return _repo.Add(item);
    }

    public T Update(T item)
    {
        return _repo.Update(item);
    }

    public void Delete(int id)
    {
        _repo.Delete(id);
    }

    public T Get(int id)
    {
        return _repo.Get(id);
    }

    public IEnumerable<T> Get()
    {
        return _repo.Get();
    }

    public IEnumerable<T> Get(Func<T,bool> filter)
    {
        return _repo.Get(filter);
    }
}