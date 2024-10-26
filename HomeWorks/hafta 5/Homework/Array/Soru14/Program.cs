namespace Soru14;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 126336, 213699, 6633333, 45999, 5, 21212121, 7, 8, 12, 56136, 47, 419, 15333, 14, 78333, 25, 16, 33, 63939393, 72};
        int result=0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]%3==0)
            {
                System.Console.WriteLine($"3'e bölünebilen sayılar: {numbers[i]}");
                result += numbers[i];
            }
           
        }
         System.Console.WriteLine($"Sayıların toplamı: {result}");
         

         string resultString = result.ToString();

        for (int i = 0; i < resultString.Length; i++)
        {
            System.Console.Write(resultString[i]);

            if ((i+1)%5==0 && i!= resultString.Length-1)
            {
                System.Console.Write(" ");
            }


        }
         
       System.Console.WriteLine();
        
        
        
        
        
            }
}
