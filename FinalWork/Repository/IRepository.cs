using FinalWork.Model;

namespace FinalWork.Repository;

public interface IRepository<T> where T : Animal
{
    List<T> GetAll();
    T Get(int id);
    void Add(T value);
    void Update(int id);
    bool Delete(int id);
}