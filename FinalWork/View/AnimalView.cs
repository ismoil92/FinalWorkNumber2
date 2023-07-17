using FinalWork.Controller;
using FinalWork.Model;

namespace FinalWork.View;

public class AnimalView
{

    public static Animal SelectCommand()
    {
        Console.Write("Выберите команду. 1-Создать животного, 2-Показать список животных:");
        int numb = Convert.ToInt32(Console.ReadLine());
        switch (numb)
        {
            case 1:
                Console.Write("Выберите тип животного. 1-Домашный, 2-Вьючный:");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == 1)
                    return AnimalController.SelectAndCreateAnimal();
                else
                    return AnimalController.SelectAndCreateAnimal();
            case 2:
                Console.Write("Выберите тип животного. 1-Домашный, 2-Вьючный:");
                int type2 = Convert.ToInt32(Console.ReadLine());
                if (type2 == 1)
                    AnimalController.GetHomeAnimal();
                else
                    AnimalController.GetPackAnimal();
                break;
        }
        return null!;
    }

    public static void AddAnimal(Animal animal)
    {
        Console.Write("Выберите тип животного. 1-Домашный, 2-Вьючный:");
        int type = Convert.ToInt32(Console.ReadLine());
        if (type == 1)
            AnimalController.AddHomeAnimal(animal);
        else
            AnimalController.AddPackAnimal(animal);
    }
}