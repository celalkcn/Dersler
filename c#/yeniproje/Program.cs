
using System;
using System.Net;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main()
    {
        //     int degiskenAdi = 56;
        //     int degiskenAddi2 = 44;
        //     System.Console.WriteLine("+iki değiskenin toplamı " + (degiskenAdi + degiskenAddi2));//cw yaz


        //     #region TmSyi 
        //     // vs code ctrl ö
        //     // ctrl+kc  yourmları kaldırma crtl ku
        //     // c# da yazılan ayrıca belirtilmedilçe int tipinde kabul edilir

        //     #endregion
        //     byte studentPoint = 15;
        // System.Console.WriteLine(studentPoint);

        //     decimal mas = 0.5m;
        //     #region  diğer tipler 

        //                 bool varMi = true;
        //     char ceva = 'a';
        //     //tek veri tutar/ type vır tutugu alan misali
        //     // düzenlemek icin format decıment 
        //     #endregion

        // 1. ödev
        // int sayi1 = 45;
        // int sayi2 = 31;
        // int toplam = sayi1+sayi2;
        // System.Console.WriteLine(toplam);    

        // 2. ödev

        // double sayi1 = 10.2;
        // double sayininKaresi = Math.Pow(sayi1,2);
        // System.Console.WriteLine("sayinin karesi "+sayininKaresi);

        // 3. ödev
        // string adSoyad= "celal uğur koçan";
        // int yas= 25;
        // System.Console.WriteLine("Benim adım  "+adSoyad+" ve yaşım "+yas);

        // #region 
        // // Bir ürünün fiyatı girildiğinde kdv dahil fiyatını belirtin

        //  console.whrite("ürün fiyatını giriniz")
        // decimal productPrice = decimal.Parse(Console.ReadLine());
        // double vatRate = 0.18;
        // double vat = (double)productPrice * vatRate;
        // decimal totalProductPrice = productPrice + (decimal)vat;
        // string resultMessage = $"Kdv Dahil fiyat:{totalProductPrice}";
        // #endregion
        // Console.Write("Ürün fiyatını giriniz: ");
        // decimal productPrice = decimal.Parse(Console.ReadLine());

        // double vatRate = 0.18;
        // double vat = (double)productPrice * vatRate;
        // decimal totalProductPrice = productPrice + (decimal)vat;

        //             string resultMessage=$@"Ürün Fiyatı     : {productPrice}
        // KDV             : {vat}
        // KDV Dahil Fiyat : {totalProductPrice}
        //             ";
        // string resultMessage = $"Ürün Fiyatı     : {productPrice}\nKDV             : {vat}\nKDV Dahil Fiyat : {totalProductPrice}";
        // Console.WriteLine(resultMessage);

        // #region Sıcaklık Dönüştürme
        // //Kullanıcıdan Celsius cinsinden alınan sıcaklık değerini, Fahrenheit cinsine çevirip ekrana her ikisini de alt alta yazdıran kodu hazırlıyoruz.
        // Console.Write("sıcaklık kaç derece?:");
        // double celcius = double.Parse(Console.ReadLine());
        // double fahre = celcius * 1.8 + 32;
        // string resultMessage = $"Celcius: {(int)celcius}\n fahre: {(int)fahre}";
        // //Console.Clear();
        // System.Console.WriteLine("sonuç");
        // System.Console.WriteLine("----");
        // System.Console.WriteLine(resultMessage);

        // #endregion
        #region  kg yi grama çevir
        Console.Write("kam gram");
        double kilogram = double.Parse(Console.ReadLine());
        double gram = kilogram * 1000;
        string resultMessage = $" kg: {(double)kilogram}\n gram {(int)gram}";
        // string resultMessage = "kilogramın gram hali  " + (double)gram;
        System.Console.WriteLine(resultMessage);


        #endregion


    }
}