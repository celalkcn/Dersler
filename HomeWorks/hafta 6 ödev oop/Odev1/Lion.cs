using System;

namespace Odev1;

public class Lion : Animal
{
    public Lion(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void SesCıkar()
    {
        System.Console.WriteLine($"{Name} kükredi");


    }


}
