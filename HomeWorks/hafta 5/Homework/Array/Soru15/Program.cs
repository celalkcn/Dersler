namespace Soru15;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 21, 3, 4, 5, 63, 7, 8, 12, 56, 47, 41, 15, 13, 78, 25 };
        int[] oddNumber= new int[20];
        int oddCount=0;
       
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]%2==1)
            {
                oddNumber[oddCount++]= numbers[i];
            }
            Array.Sort(oddNumber);
        }

        System.Console.WriteLine();
        int[] newNumbers = new int[numbers.Length];
        Array.Copy(numbers, newNumbers, numbers.Length);

        foreach (var item in newNumbers)
        {
            System.Console.Write(item+" ");
        }
        
    }
}
