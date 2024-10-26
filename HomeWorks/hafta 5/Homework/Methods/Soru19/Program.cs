namespace Soru19;
/* Belirli bir sayı aralığındaki asal sayıları bulan bir metot yazın. */


class Program
{

    static string PrimeNumber(){

        System.Console.Write("Bir sayı giriniz: ");
        int sayi1 = int.Parse(Console.ReadLine());

        System.Console.Write("Bir sayı giriniz: ");
        int sayi2 = int.Parse(Console.ReadLine());


        for (int i = sayi1; i < sayi2; i++)
        {
            if (i <= 1)
            {
                break; 
            }

            bool isPrime = true;



        }


   





    }
    static void Main(string[] args)
    {
        string result = PrimeNumber();
        System.Console.WriteLine(result);
    }
}
