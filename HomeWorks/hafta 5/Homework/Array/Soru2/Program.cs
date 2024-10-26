using System.Net.WebSockets;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml;

namespace Soru2;
// Klavyeden girilen 10 sayıyı bir diziye atayın. Bu sayılardan çift olanları for döngüsü kullanarak ayrı bir diziye aktarın. Ardından bu çift sayı dizisini küçükten büyüğe sıralayın.
class Program
{
    static void Main(string[] args)
    {


        
         Random rnd = new Random();
            int[] numbers = new int[10];
            int evenCount = 0;

            int[] evenNumber = new int[evenCount];




                for (int i = 0; i<numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1,50);
                    System.Console.Write(numbers[i]+ " ");

                    if (numbers[i] % 2 == 0)
                    {
                        evenNumber[evenCount]= numbers[i];
                        evenCount++;
                    }
                }

                 Array.Sort(evenNumber, 0, evenCount);
        foreach (var even in evenNumber)
        {
            System.Console.Write(even);
        }








        //  System.Console.WriteLine();



        // int[] evenNumber = new int[numbers.Length];
        //Array.Copy(numbers, evenNumber, numbers.Length); ;
        // foreach (var even in evenNumber)
        // {
        //     System.Console.Write(even + " ");
        // } */
    }

}










