using System;

namespace Project23_InheritanceSamples.SchoolSystem;

public class Kisi
{
    public Kisi(string adı, string soyad, DateTime dogumtarihi)
    {
        Adı = adı;
        Soyad = soyad;
        Dogumtarihi = dogumtarihi;
    }

    public string Adı { get; set; }

    public string Soyad { get; set; }

    public DateTime Dogumtarihi { get; set; }

    public byte Yas  // salt okunur yani read only
    {
        get
        {
            return (byte)(DateTime.Now.Year - Dogumtarihi.Year);

        }

    }

    public virtual void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($"Ad: {Adı}\nsoyadı {Soyad}\nyaş:{Yas}");
        


    }


}
