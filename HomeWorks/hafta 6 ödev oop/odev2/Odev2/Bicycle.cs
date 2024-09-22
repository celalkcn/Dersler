using System;

namespace Odev2;

public class Bicyle : Vehicle
{
    public Bicyle(string make, string model, int year, string zilVarMı) : base(make, model, year)
    {
        ZilVarMı = zilVarMı;
    }
    public string ZilVarMı { get; set; }

    public override void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($" Modeli {Model} olan aracın markası {Make} dir.yılı {Year}  zili ise {ZilVarMı}");



    }







}
