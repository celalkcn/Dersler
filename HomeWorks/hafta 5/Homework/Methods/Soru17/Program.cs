namespace Soru17;
/* Bir listede belirli bir sayının kaç defa geçtiğini döndüren bir metot yazın. */


class Program
{

     static int RepeatCount(){

        Random rnd = new Random();
        List<int> numbers = new List<int>();
        int numberCount = 8;


       


        for (int i = 0; i < numberCount; i++)
        {
            int randomNumber = rnd.Next(1, 5);
            numbers.Add(randomNumber);
            System.Console.Write(randomNumber+" ") ;
        }

        List<int> repeatNumber = new List<int>();
        int repeatCount = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            int currentNumber = numbers[i];

            for (int j = 0; j <i ; j++)
            {
                if (currentNumber == numbers[j])
                {
                    repeatCount++;
                }
            }
        }

        return repeatCount++;
        

    }
    static void Main(string[] args)
    {
       int result = RepeatCount();
       System.Console.WriteLine();
       System.Console.WriteLine(result);
    }

}