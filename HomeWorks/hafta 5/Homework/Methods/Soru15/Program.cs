using System.Globalization;

namespace Soru15;
/*Bir dizideki elemanların ortalamasını döndüren bir metot yazın.*/


class Program
{

    static double NumberAvarege(){

       Random rnd = new Random();
       int[] numbers = new int[10];
       int sum=0;
          
       for (int i = 0; i < numbers.Length; i++)
       {
          numbers[i] = rnd.Next(1, 50);
          System.Console.Write(numbers[i]+" ");
          sum += numbers[i];
          
        }

        double avarege = sum / numbers.Length;
        return avarege;

    }





    static void Main(string[] args)
    {
        
        double result =NumberAvarege();
        System.Console.Write($"\nSayıların ortalaması : {result}");
    }
}
