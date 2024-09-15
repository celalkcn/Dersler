using System;

namespace Project23_InheritanceSamples;

public class Animal
{
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }


    public virtual void MakeSound()

    {

        System.Console.WriteLine($"{Name} ses çıkartıyor!!!");


    }

// override method ezmek için bunu yapabilmek için public methodun yanına virtual yazman gerekiyor




}
