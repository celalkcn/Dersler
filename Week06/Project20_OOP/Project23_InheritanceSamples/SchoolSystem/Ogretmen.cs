using System;
using System.Security.Cryptography.X509Certificates;

namespace Project23_InheritanceSamples.SchoolSystem;
// ogretmen bir kisidri 
// ogretmenin ek olarak Brans ve maaş bilgisi olacak
// maaş bilgisi negatif değer olarak girilmesine izin verilmeyecek!
// öğretmenin bilgileri ekrana yazdırılırken Branş be Maaş Bilgisi de yazdırılacak
public class Ogretmen : Kisi
{
    public Ogretmen(string adı, string soyad, DateTime dogumtarihi, string brans, decimal maas) : base(adı, soyad, dogumtarihi)
    {
        this.maas = maas;
        Brans = brans;
    }
    public string Brans { get; set; }
    decimal maas;
    public decimal Maas
    {
        get
        {
            return maas;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Negatif bir Maaş bilgisi olamaz");              //argümanlarda hata var demek throw gördüğünde haata durur aşagıya bakmaz yani maas = value değil 


            }
            maas = value;

        }


    }

    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"maaş: {Maas}\nbranş : {Brans}");
    }
// car managament  1 Vehicle adında bir class yaratın 
// Brand, Model , year propeteryleri olsun  
// start ve stop metodu olsun araba çalıştı araba durdu
// bir vehicle yaratılırken Brand, Model ve year Bilgileri verilmek zorunda olsun

// 22222 Car adlı bir class olsuturun 
// her car bir vehicle dir
// ek olarak numberOfDoors adlı bir özelliği olsun ve başta verilmek zorunda olsun 
// OpenTrunk adlı bir metodu olsun 

//3333 MotorCycle adlı bir class olusturun 
// her MotorCycle bir vehicledir
// ek olarak CoolingSystem adlı bir propertsi olsun ve yaratılırken verilmek zorunda olsujn 
}
