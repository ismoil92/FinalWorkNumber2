using System.ComponentModel.DataAnnotations;

namespace FinalWork.Model;

public class Horse:Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Commands { get; set; }

    public Horse()
    {
        Name = string.Empty;
        Age = 0;
        Commands = new List<string>();
    }

    public override string ToString()
    {
        return $"ID:{Id}, Type:{Type}, Name:{Name}, Age:{Age}";
    }
}