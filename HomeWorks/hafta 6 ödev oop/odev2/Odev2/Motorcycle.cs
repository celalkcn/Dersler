using System;

namespace Odev2;

public class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model, int year, string hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }

    public string HasSidecar { get; set; }

    public override void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($" Modeli {Model} olan aracın markası {Make} dir.yılı {Year}  sepeti {HasSidecar}");



    }

}
