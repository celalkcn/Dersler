namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[15];

        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 500);
            System.Console.WriteLine(numbers[i]+" ");
        }

        foreach (var sayi in numbers)
        {
            if (sayi > max) max = sayi;
            if (sayi < min) min = sayi;
        }

       

        System.Console.WriteLine("Max: " + max);
        System.Console.WriteLine("Min: " + min);








    }
}
