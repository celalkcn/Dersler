namespace odev1;
//  1’den 100’e kadar olan tüm asal sayıları bulan ve ekrana yazdıran bir program yazın. Asal sayılar yalnızca 1 ve kendisi ile bölünebilen pozitif tam sayılardır. Örneğin, 2, 3, 5, 7 gibi sayılar asal sayıdır.
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("1 den 100 e kadar olan asal sayıları yazdıran program");

        int sayi = 100;


        for (int i = 2; i <= sayi; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= i - 1; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            System.Console.WriteLine($"{i} {(isPrime ? "asal" : "asal değil")}");
        }



    }
}
