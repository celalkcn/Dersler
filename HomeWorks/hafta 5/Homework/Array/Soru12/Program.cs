namespace Soru12;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        Random rnd = new Random();
      //  int count=0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 10);      
        }

        int count=0;
        int maxCount=0;

        foreach (var item in numbers)
        {
            System.Console.WriteLine(item);

            for (int i = item-1; i < numbers.Length; i++)
            {
                if (i==item)
                {
                    count++;
                }

                System.Console.WriteLine(item);
                System.Console.WriteLine(count);

            }

        }


       

    }
}
