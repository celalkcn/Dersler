using System;

namespace Odev1;

public class Elephant : Animal
{
    public Elephant(string name, int age, string species) : base(name, age, species)
    {
    }

    public override void SesCıkar()
    {
        System.Console.WriteLine($"{Name} biraz fazla bağırıyor");


    }

}
