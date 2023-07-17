using FinalWork.Model;

namespace FinalWork.Repository;

public class DogRepository : IRepository<Dog>
{

    private List<Dog> Dogs;

    public DogRepository()
    {
            Dogs = new List<Dog>();
    }
    public void Add(Dog value) => Dogs.Add(value);

    public bool Delete(int id)
    {
        var dog = Dogs.FirstOrDefault(x => x.Id == id);
        if (dog != null)
        {
            Dogs.Remove(dog);
            return true;
        }
        return false;
    }

    public Dog Get(int id)
    {
        var dog = Dogs.FirstOrDefault(x => x.Id == id);
        if(dog != null)
            return dog;
        return null!;
    }

    public List<Dog> GetAll() => Dogs;

    public void Update(int id)
    {
        var dog = Dogs.FirstOrDefault(x => x.Id == id);
        if (dog != null)
            (dog.Name, dog.Age) = ConsoleWriteLine();
    }

    private static (string name, int age) ConsoleWriteLine()
    {
        Console.Write("Введите имя:");
        string name = Console.ReadLine()!;
        Console.Write("Введите возраст:");
        int age = Convert.ToInt32((Console.ReadLine()!));
        return (name, age);
    }
}