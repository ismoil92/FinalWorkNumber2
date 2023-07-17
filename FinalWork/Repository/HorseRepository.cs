using FinalWork.Model;

namespace FinalWork.Repository;

public class HorseRepository : IRepository<Horse>
{
    private List<Horse> Horses;

    public HorseRepository() => Horses = new List<Horse>();
    public void Add(Horse value) => Horses.Add(value);

    public bool Delete(int id)
    {
        var horse = Horses.FirstOrDefault(h => h.Id == id);
        if(horse != null)
        {
            Horses.Remove(horse);
            return true;
        }
        return false;
    }

    public Horse Get(int id)
    {
        var horse = Horses.FirstOrDefault(h => h.Id == id);
        if (horse != null)
            return horse;
        return null!;
    }

    public List<Horse> GetAll() => Horses;

    public void Update(int id)
    {
        var horse = Horses.FirstOrDefault(x => x.Id == id);
        if (horse != null)
            (horse.Name, horse.Age) = ConsoleWriteLine();
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