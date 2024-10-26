using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Soru7;
/*Saat, dakika ve saniye alan bir metot yazın. Bu metot zamanı "HH:MM:SS" formatında döndürsün.*/


class Program
{

    static string TimeTempt(){

        Console.Write("Saati giriniz: ");
        int hour = int.Parse(Console.ReadLine());

        Console.Write("Dakikayı giriniz: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Saniyeyi giriniz: ");
        int sec = int.Parse(Console.ReadLine());



        return $"{hour:D2}:{min:D2}:{sec:D2}";

    }


    static void Main(string[] args)
    {

       string result = TimeTempt();
       System.Console.WriteLine(result);


    }
}
