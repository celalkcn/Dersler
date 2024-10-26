namespace Soru13;
//Bir dizideki tek sayıları toplayan ve bu toplamın çift mi, tek mi olduğunu kontrol eden bir program yazın. Toplamla birlikte eğer toplam tek ise, "Toplam tek sayı" mesajı, çift ise "Toplam çift sayı" mesajı ekrana yazdırılmalı.
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 12,56,47,41, 15, 14, 78, 25, 16};
        int result=0;



        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]%2==1)
            {
                System.Console.Write(numbers[i]+" ");
                 result +=i;
            }
        }
        System.Console.WriteLine();

        if (result % 2 == 0)
        {
            System.Console.WriteLine($"Sayıların toplamı: {result} çift sayıdır.");

        }
        else
        {
            System.Console.WriteLine($"Sayıların toplamı: {result} tek sayıdır.");
        }




    }
}
