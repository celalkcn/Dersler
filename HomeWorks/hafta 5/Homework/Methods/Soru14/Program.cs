namespace Soru14;
/* İki tarih arasındaki gün sayısını hesaplayan bir metot yazın.*/


class Program
{

    static int FindSpread(){
        System.Console.WriteLine("Bir tarih giriniz (yyyy - MM - dd formatında) : ");
        string input = Console.ReadLine();

        System.Console.WriteLine("Bir tarih giriniz (yyyy - MM - dd formatında) : ");
        string input2 = Console.ReadLine();

        DateTime date1;
        DateTime date2;

        bool properDate1 = DateTime.TryParseExact(input, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture  , System.Globalization.DateTimeStyles.None, out date1 );

        bool properDate2 = DateTime.TryParseExact(input2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date2);

        if (!properDate1)
        {
            return -1;
        }

        if (!properDate2)
        {
            return -1;
        }

            TimeSpan diffence = date2- date1;
            return  diffence.Days;



    }
   



    static void Main(string[] args)
    {
      int result = FindSpread();

      System.Console.WriteLine($"İki tarih arasındaki gün farkı : {result}");
    }
}
