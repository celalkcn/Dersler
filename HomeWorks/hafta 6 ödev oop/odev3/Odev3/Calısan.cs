using System;

namespace Odev3;

public class Calısan
{
    public Calısan(string name, int ıd, int salary)
    {
        Name = name;
        Id = ıd;
        Salary = salary;
    }

    public string Name { get; set; }

    public int Id { get; set; }

    public int Salary { get; set; }


    public virtual void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($" ");



    }

}
