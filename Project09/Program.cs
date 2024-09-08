using System.Drawing;

namespace Project09;

class Program
{
    static void Main(string[] args)
    {
        //   int x=10;
        //   if (x>15)
        //     {
        //         System.Console.WriteLine("Büyüktür");
        //     }

        // else if (x<15)
        // {

        //     System.Console.WriteLine("küçüktür");
        // }

        // else {

        //     System.Console.WriteLine("eşittir");
        // }

        // Console.Write("yasınızı giriniz");
        // int yas = int.Parse(Console.ReadLine());

        // if (yas>=18){
        //     System.Console.WriteLine("resittir");

        // }

        // else {
        //     System.Console.WriteLine($"resit değilsiniz. {18-yas} yıl sonra esşit olacaksınız!");
        // }
        // DRY-DON T repeat yourself



        // System.Console.Write("Adınızı Giriniz");
        // string fullName =Console.ReadLine();

        // System.Console.Write("Yaşını Gir gardaş:");
        // byte age =byte.Parse(Console.ReadLine());


        // String resultMessage = age>= 18 ? $"Giriş yapabilirsin {fullName} bey" : $"{18-age} yıl sonra reşit olucaksın geri bas"; 

        // System.Console.WriteLine(resultMessage);
        // // else if olayını basit taktiği    turner if bu bunu mesage içine aktarmak için kullan sadece abartılı şeylerde kullanma bro


        // System.Console.WriteLine("notunuzu giriniz");

        //     byte not = byte.Parse(Console.ReadLine());
        //     string resultMessage ;
        //     if (not >=50)
        //     {
        //      resultMessage = "Geçti!";

        //     }  
        //     else{

        //         resultMessage= "zort";

        //     System.Console.WriteLine(resultMessage);}


        #region switch

        // int point = 120;
        // byte resultPoint=0;

        // switch (point)
        // {

        //     case < 45:
        //         resultPoint = 1;
        //         break;

        //     case < 55:
        //         resultPoint = 2;
        //         break;
        //     case < 70:
        //         resultPoint = 3;
        //         break;
        //     case < 85:
        //         resultPoint = 4;
        //         break;
        //     case <= 100:
        //         resultPoint = 5;
        //         break;


        //     default:

        //         System.Console.WriteLine("Lütfen 0-100 arası giriniz");
        //     break;
        // }
        //     if(point>0 && point <=100){
        //     System.Console.WriteLine(resultPoint);
        //     }

        // bunun aynısı amele yöntemiyle (if) ile ypaar mısın.


        #endregion
        // girilen tarihin hafta içi mi yoksa hafta sonu mu oldugunu söyleyen kodu yazınız.
        #region örnek 
        

        // System.Console.WriteLine("Bir tarih giriniz(gg.aa.yyyy):");

        // string inputDate = Console.ReadLine();

        // if (DateTime.TryParse(inputDate, out DateTime date))
        // {
        //     DayOfWeek dayOfWeek = date.DayOfWeek;
        //     System.Console.WriteLine(dayOfWeek  );
        //     System.Console.WriteLine(date.ToLongDateString());
        // switch(dayOfWeek)
        // {
        //     case DayOfWeek.Saturday:
        //     case DayOfWeek.Sunday:
        //         System.Console.WriteLine("iyi tatiller!");
        //         break;
        //     default:
        //     System.Console.WriteLine("iyiçalışmalar");
        //         break;


        // }


        // }
        // else {

        //     System.Console.WriteLine("hatalı tarih girişi!!!!!!!!!!!!");

        // }

        #endregion

    // girilen tarihin hangi mevsims denge geldiğini

    System.Console.WriteLine("Bir tarih giriniz");
    int tarih =int.Parse(Console.ReadLine());
    
    switch (tarih)
    {
        case 
        
        default:
    }



    }
}
