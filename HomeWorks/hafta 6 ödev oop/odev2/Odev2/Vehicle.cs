using System;

namespace Odev2;

public class Vehicle
{
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public virtual void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($" Modeli {Model} olan aracın markası {Make} dir.yılı ise {Year}");



    }
    

}
