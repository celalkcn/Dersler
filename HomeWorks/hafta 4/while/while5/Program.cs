namespace While_Soru5;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Bir sayı giriniz: ");
        string number = Console.ReadLine();

        char[] array = number.ToCharArray();
        
        Array.Reverse(array);

        string reversedNum = new string(array);

        System.Console.WriteLine(reversedNum); 


    }
}
