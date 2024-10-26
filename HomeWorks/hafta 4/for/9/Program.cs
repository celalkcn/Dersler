namespace odev1;

// 9. Kullanıcıdan bir pozitif tam sayı alın.Bu sayının asal olup olmadığını kontrol eden bir program yazın.Eğer sayı asal ise ekrana "Asal Sayıdır" değilse "Asal Sayı Değildir" yazdırın.


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i < number 
        ; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                System.Console.WriteLine($"{number}: asal değildir.");
                break;
            }
        }
        System.Console.WriteLine(number);

    }
}
