namespace While_Soru8;

class Program
{
    static void Main(string[] args)
    {
        int number=1;
        int numberCount = 0;
        int count = 0;
        double numOrt=0;


        while (true)
        {
           System.Console.Write("Bir sayı giriniz: "); 
           number = int.Parse(Console.ReadLine());
           
          if (number > 100)
          {
            break;

          }

            numberCount++;

            count += number;
             numOrt = count / numberCount;

        }
        System.Console.WriteLine($"Sayı adedi : {numberCount}");
        System.Console.WriteLine($"Sayıların toplamı : {count}");
        System.Console.WriteLine($"Sayıların ortalaması : {numOrt}");



/* 
    int number = 0;
    int total = 0;

    int i = 1;
    while (true)
    {
      Console.Write("Bir sayı giriniz: ");
      number = int.Parse(Console.ReadLine());
      total += number;

      System.Console.WriteLine($"Girilen değer sayısı: {i}  toplam: {total}");
      i++;

      if (number > 100)
      {
        break;
      }
    } */

  }
}
