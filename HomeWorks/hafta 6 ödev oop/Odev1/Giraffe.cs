using System;

namespace Odev1;

public class Giraffe : Animal
{
    public Giraffe(string name, int age, string species) : base(name, age, species)
    {
    }

    public override void SesCıkar()
    {
        System.Console.WriteLine($"{Name} maalesef cıkaramadı");


    }
}
