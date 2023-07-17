using FinalWork.Model;

namespace FinalWork.Repository;

public class CamelRepository : IRepository<Camel>
{
    private List<Camel> Camels;

    public CamelRepository()
    {
        Camels = new List<Camel>();
    }
    public void Add(Camel value) => Camels.Add(value);

    public bool Delete(int id)
    {
        var camel = Camels.FirstOrDefault(c => c.Id == id);
        if (camel != null)
        {
            Camels.Remove(camel);
            return true;
        }
        return false;
    }

    public Camel Get(int id)
    {
        var camel = Camels.FirstOrDefault(c => c.Id == id);
        if (camel != null)
            return camel;
        return null!;
    }

    public List<Camel> GetAll() => Camels;

    public void Update(int id)
    {
        var camel = Camels.FirstOrDefault(x => x.Id == id);
        if (camel != null)
            (camel.Name, camel.Age) = ConsoleWriteLine();
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