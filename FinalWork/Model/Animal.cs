using System.ComponentModel.DataAnnotations;

namespace FinalWork.Model;

public class Animal
{
    [Key]
    public int? Id { get; set; } = 0;
    public string Type { get; set; }

    public Animal()
    {
        Id++;
        Type = string.Empty;
    }

    public override string ToString()
    {
        return $"ID:{Id}, Type:{Type}";
    }
}