namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(-200, 200);

        }

        int[] positive = new int[numbers.Length];
        int[] negative = new int[numbers.Length];
        int positiveIndex = 0;
        int negativeIndex = 0;

        int index = 0;

        while (index < numbers.Length)
        {
            if (numbers[index] > 0)
            {
                positive[positiveIndex] = numbers[index];
                positiveIndex++;
            }
            else if (numbers[index] < 0)
            {
                negative[negativeIndex] = numbers[index];
                negativeIndex++;
            }
            index++;
        }

        System.Console.WriteLine();

        for (int j = 0; j < numbers.Length; j++)
        {
            System.Console.Write(numbers[j] + " ");
        }
        System.Console.WriteLine();

        for (int k = 0; k < positive.Length; k++)
        {
            System.Console.Write(positive[k] + " ");
        }
        System.Console.WriteLine();
        for (int l = 0; l < negative.Length; l++)
        {
            System.Console.Write(negative[l] + " ");
        }






    }

}
