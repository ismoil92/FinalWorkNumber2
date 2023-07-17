using FinalWork.Model;

namespace FinalWork.Repository;

public class CatRepository : IRepository<Cat>
{
    private List<Cat> Cats;

    public CatRepository() => Cats = new List<Cat>();
    public void Add(Cat value) => Cats.Add(value);

    public bool Delete(int id)
    {
        var cat = Cats.FirstOrDefault(x => x.Id == id);
        if (cat != null)
        {
            Cats.Remove(cat);
            return true;
        }
        return false;
    }

    public Cat Get(int id)
    {
        var cat = Cats.FirstOrDefault(x => x.Id == id);
        if (cat != null)
            return cat;
        return null!;
    }


    public List<Cat> GetAll() => Cats;

    public void Update(int id)
    {
        var cat = Cats.FirstOrDefault(x => x.Id == id);
        if (cat != null)
            (cat.Name, cat.Age) = ConsoleWriteLine();
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