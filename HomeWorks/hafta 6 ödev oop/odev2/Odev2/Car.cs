using System;

namespace Odev2;

public class Car : Vehicle
{
    public Car(string make, string model, int year) : base(make, model, year)
    {
    }

    public Car(string make, string model, int year, int maxSpeed) : base(make, model, year)
    {
        MaxSpeed = maxSpeed;
    }
    public int MaxSpeed { get; set; }

    public override void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($" Modeli {Model} olan aracın markası {Make} dir.yılı {Year}  maksimum hızı ise {MaxSpeed}");



    }


}
