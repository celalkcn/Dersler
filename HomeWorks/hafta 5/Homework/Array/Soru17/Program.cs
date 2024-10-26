namespace Soru17;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 21, 3, 4, 5, 63, 7, 8, 12, 56, 47, 41, 15, 13, 78, 25 };
        int max1 = int.MinValue;
        int max2 = int.MinValue;
      
        for (int i = 0; i < numbers.Length; i++)
        {

            System.Console.Write(numbers[i] + " ");

            if (numbers[i] > max1)     
            {
                max1 = numbers[i];
            }

         else if (numbers[i] > max2 && max2 != numbers[i])
            {
                   
                    max2 = numbers[i];
            }

        }
        System.Console.WriteLine();
        System.Console.WriteLine($"1.En büyük sayı: {max1}");
        System.Console.WriteLine($"2.En büyük sayı: {max2}");

    }
}
