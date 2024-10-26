namespace Soru12;
/*Bir tarih verildiğinde, bu tarihin hangi gün olduğunu döndüren bir metot yazın.*/

class Program
{

    static string FindDate(){
        System.Console.WriteLine("Yıl  giriniz: ");
        int year = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Ay  giriniz: ");
        int month = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Gün  giriniz: ");
        int day = int.Parse(Console.ReadLine());

        
        DateTime date = new DateTime(year, month, day);
        string dayfWeek = date.DayOfWeek.ToString();

        return dayfWeek;

    }


    static void Main(string[] args)
    {
      string result = FindDate();
      System.Console.WriteLine(result);
    }
}
