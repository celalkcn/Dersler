using System;

namespace Project23_InheritanceSamples.SchoolSystem;
// bir kisidir
// öğrencinin  numarası vardir bilgileri ekrana yazdırılırken ög nuamrası da yazdırılmalıdır
public class MyOgrenci : Kisi // ctrl . generate const 
{
    public MyOgrenci(string adı, string soyad, DateTime dogumtarihi, int ogrenciNo) : base(adı, soyad, dogumtarihi)
    {
        OgrenciNo = ogrenciNo;
    }
    public int OgrenciNo { get; set; } // add parametres kullan 

    // sonra virtual yap ki metodu polimor... kullanmak icin override
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Numara: {OgrenciNo}");
    }



}
