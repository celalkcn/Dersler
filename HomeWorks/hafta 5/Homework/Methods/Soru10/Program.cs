namespace Soru10;
/*Bir sayı dizisi alıp, dizideki tüm elemanların toplamını döndüren bir metot yazın.*/


class Program
{

    static int NumberSum(){
        
        System.Console.Write("Dizinin boyutunu giriniz: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] numbers = new int[lenght];
        int sum=0;

       for (int i = 0; i < numbers.Length; i++)
      {
        System.Console.WriteLine("Bir sayı giriniz: ");
          //  int sayi = int.Parse(Console.ReadLine());
            numbers[i] = int.Parse(Console.ReadLine());
           // numbers[i] = sayi;
           // System.Console.WriteLine(numbers[i]+" ");
           // sum += sayi;
           sum += numbers[i];
        }

        return sum;
    }



    static void Main(string[] args)
    {
        int result = NumberSum();
        System.Console.WriteLine($"Sayıların toplamı: {result}");
       
    }
}
