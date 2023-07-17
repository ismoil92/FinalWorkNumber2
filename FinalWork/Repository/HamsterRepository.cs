using FinalWork.Model;

namespace FinalWork.Repository;

public class HamsterRepository : IRepository<Hamster>
{
    private List<Hamster> Hamsters;

    public HamsterRepository() => Hamsters = new List<Hamster>();
    public void Add(Hamster value) => Hamsters.Add(value);

    public bool Delete(int id)
    {
        var hamster = Hamsters.First(x => x.Id == id);
        if(hamster != null)
        {
            Hamsters.Remove(hamster);
            return true;
        }
        return false;
    }

    public Hamster Get(int id)
    {
        var hamster = Hamsters.First(x => x.Id == id);
        if (hamster != null)
            return hamster;
        return null!;
    }

    public List<Hamster> GetAll() => Hamsters;

    public void Update(int id)
    {
        var hamster = Hamsters.FirstOrDefault(x => x.Id == id);
        if (hamster != null)
            (hamster.Name, hamster.Age) = ConsoleWriteLine();
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