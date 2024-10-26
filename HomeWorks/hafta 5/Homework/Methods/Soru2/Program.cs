namespace Soru2;
/* İki sayıyı karşılaştıran ve en büyüğünü döndüren bir metot yazın.*/


class Program
{
    static int MinMax(){

        System.Console.WriteLine("Bir sayı  giriniz: ");
        int sayi1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Bir sayı  giriniz: ");
        int sayi2 = int.Parse(Console.ReadLine());


        if (sayi1 > sayi2)
        {
            return sayi1;
        }
        else
        {
            return sayi2;
        }

    }
    static void Main(string[] args)
    {
        int maxNumber = MinMax();
        System.Console.WriteLine($"Max number: {maxNumber}");

    }
}
