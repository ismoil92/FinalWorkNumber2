using FinalWork.View;

while (true)
{
    var animal = AnimalView.SelectCommand();
    if (animal != null)
        AnimalView.AddAnimal(animal);
    else
        break;
}