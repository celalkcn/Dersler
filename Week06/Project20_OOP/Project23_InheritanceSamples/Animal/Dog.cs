using System;

namespace Project23_InheritanceSamples;

public class Dog : Animal
{
    public Dog(string name, int age, int oldFactionLevel, string breed) : base(name, age)
    {
        OldFactionLevel = oldFactionLevel;
        Breed = breed;
    }
    public int OldFactionLevel { get; set; }

    public string Breed { get; set; }

    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} havladı");
    }


}
