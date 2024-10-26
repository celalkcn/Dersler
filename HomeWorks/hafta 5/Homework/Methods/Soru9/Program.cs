using System.Runtime.ConstrainedExecution;

namespace Soru9;
/*Bir sayı dizisi alıp, bu listedeki en küçük sayıyı döndüren bir metot yazın.*/ 
class Program
{
    static int MinNumber(){

        System.Console.Write("Dizinin boyutunu giriniz: ");
        int lenght = int.Parse(Console.ReadLine());
       
        int[] numbers = new int[lenght];


        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            
            numbers[i] = int.Parse(Console.ReadLine());
            
           // System.Console.WriteLine(numbers[i] + " ");
            
        }
        Array.Sort(numbers);
        System.Console.WriteLine();
        foreach (var item in numbers)
        {
            System.Console.WriteLine(item);
        }
        
        int min = numbers[0];
        return min;
    }

    static void Main(string[] args)
    {
      int result = MinNumber();
      System.Console.WriteLine($"Minimum sayı: {result}");
           
    }
        
    }

