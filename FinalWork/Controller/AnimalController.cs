using FinalWork.Model;
using FinalWork.Repository;

namespace FinalWork.Controller;

public class AnimalController
{
    private static CatRepository _catRepository = new CatRepository();

    private static DogRepository DogRepository = new DogRepository();

    private static HamsterRepository HamsterRepository = new HamsterRepository();

    private static CamelRepository CamelRepository = new CamelRepository();

    private static DonkeyRepository DonkeyRepository = new DonkeyRepository();

    private static HorseRepository HorseRepository = new HorseRepository();
    public static Animal SelectAndCreateAnimal()
    {
        Console.Write("Выберите номер тип животного:1.Домашный, 2.Вьютный:");
        int typeNumber = Convert.ToInt32(Console.ReadLine());
        if(typeNumber == 1 )
        {
            Console.Write("Выберите номер домашнего животного:1.Кошка, 2.Собака, 3.Хомяк:");
            int homeNumber = Convert.ToInt32(Console.ReadLine());
            string home = "Домашный";
            switch (homeNumber)
            {
                case 1:
                    Cat cat = new Cat();
                    (cat.Name, cat.Age) = GetNameAndAge();
                    cat.Type = home;
                    return cat;
                case 2:
                    Dog dog = new Dog();
                    (dog.Name, dog.Age) = GetNameAndAge();
                    dog.Type = home;
                    return dog;
                case 3:
                    Hamster hamster = new Hamster();
                    (hamster.Name, hamster.Age) = GetNameAndAge();
                    hamster.Type = home;
                    return hamster;

            }
        }
        else
        {
            Console.Write("Выберите номер вьютного животного:1.Верблюд, 2.Лошадь, 3.Осёл:");
            int packNumber = Convert.ToInt32(Console.ReadLine());
            string pack = "Вьютный";
            switch(packNumber)
            {
                case 1:
                    Camel camel = new Camel();
                    (camel.Name, camel.Age) = GetNameAndAge();
                    camel.Type = pack;
                    return  camel;
                case 2:
                    Horse horse = new Horse();
                    (horse.Name, horse.Age) = GetNameAndAge();
                    horse.Type = pack;
                    return horse;
                case 3:
                    Donkey donkey = new Donkey();
                    (donkey.Name, donkey.Age) = GetNameAndAge();
                    donkey.Type = pack;
                    return donkey;
            }
        }
        return null!;
    }

    public static void AddHomeAnimal(Animal animal)
    {
        if (animal is Cat cat)
            _catRepository.Add(cat);
        else if (animal is Dog dog)
            DogRepository.Add(dog);
        else if (animal is Hamster hamster)
            HamsterRepository.Add(hamster);
        else
            return;
    }

    public static void AddPackAnimal(Animal animal)
    {
        if (animal is Camel camel)
            CamelRepository.Add(camel);
        else if (animal is Donkey donkey)
            DonkeyRepository.Add(donkey);
        else if (animal is Horse horse)
            HorseRepository.Add(horse);
        else
            return;
    }


    private static (string name, int age) GetNameAndAge()
    {
        Console.Write("Введите имя:");
        string name = Console.ReadLine()!;
        Console.Write("Введите возраст:");
        int age = Convert.ToInt32(Console.ReadLine());
        return (name, age);
    }

    public static void GetHomeAnimal()
    {
        Console.WriteLine("Cats");
        foreach (var cat in _catRepository.GetAll())
            Console.WriteLine(cat);
        Console.WriteLine();
        Console.WriteLine("Dogs");
        foreach (var dog in DogRepository.GetAll())
            Console.WriteLine(dog);
        Console.WriteLine();
        Console.WriteLine("Hamster");
        foreach (var hamster in HamsterRepository.GetAll())
            Console.WriteLine(hamster);
    }

    public static void GetPackAnimal()
    {
        Console.WriteLine("Cats");
        foreach (var cat in _catRepository.GetAll())
            Console.WriteLine(cat);
        Console.WriteLine();
        Console.WriteLine("Dogs");
        foreach (var dog in DogRepository.GetAll())
            Console.WriteLine(dog);
        Console.WriteLine();
        Console.WriteLine("Hamster");
        foreach (var hamster in HamsterRepository.GetAll())
            Console.WriteLine(hamster);
    }
}