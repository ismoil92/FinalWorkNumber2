using FinalWork.Model;

namespace FinalWork.Repository;

public class DonkeyRepository : IRepository<Donkey>
{
    private List<Donkey> Donkeys;

    public DonkeyRepository() => Donkeys = new List<Donkey>();
    public void Add(Donkey value) => Donkeys.Add(value);

    public bool Delete(int id)
    {
        var donkey = Donkeys.FirstOrDefault(x => x.Id == id);
        if(donkey != null)
        {
            Donkeys.Remove(donkey);
            return true;
        }
        return false;
    }

    public Donkey Get(int id)
    {
        var donkey = Donkeys.FirstOrDefault(x => x.Id == id);
        if (donkey != null)
            return donkey;
        return null!;
    }

    public List<Donkey> GetAll()=> Donkeys;

    public void Update(int id)
    {
        var donkey = Donkeys.FirstOrDefault(x => x.Id == id);
        if (donkey != null)
            (donkey.Name, donkey.Age) = ConsoleWriteLine();
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