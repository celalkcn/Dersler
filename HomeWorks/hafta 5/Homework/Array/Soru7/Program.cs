namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[50];

        int evenCount=0;     

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 500);

            if (numbers[i]%2 ==0)
            {
                System.Console.Write(numbers[i]+" ");
                evenCount +=numbers[i];
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Çift sayıların toplamı: "+ evenCount);

   
        }

    }

