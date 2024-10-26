namespace Soru1;
// 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisi içinde, dizinin her bir elemanının yalnızca bir önceki ve bir sonraki elemanı ile kıyaslandığı bir algoritma yazın. Bu algoritma, yalnızca kendinden önceki sayı ve kendinden sonraki sayı büyük olan elemanları bulmalı ve bunları ekrana yazdırmalıdır.
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] numbers = new int[10];
        int max = int.MinValue;
        int min = int.MaxValue;

    
        for (int i = 0; i < numbers.Length; i++)
        {
          numbers[i] = rnd.Next(1, 50);
            System.Console.Write(numbers[i] + " ");
        }

       for (int i = 1; i < numbers.Length; i++)
       {
        if (numbers[i-1] >  numbers[i] && numbers[i+1] > numbers[i])
        {
            System.Console.WriteLine(numbers[i]);
        }
       }
        
    }
}
